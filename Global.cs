using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    [Serializable()]

    public class G
    {
        public static bool IsModifyRerun = false;
        public static frmMAEBOM frmMAEBOM = new frmMAEBOM();
        public static MDIParent MDIParent;
        public static Quotation2 quotation2;
        public static List<ColorCost> listColorCost=new List<ColorCost>();
        public static List<PackingCost> listPackingCost = new List<PackingCost>();
              public static DataTable dtPacking, dtColor,dtCommssion;
        
    }
    public class Access
    {
    
        public static void SavePackingCost(List<PackingCost> list)
        {

            using (MemoryStream ms = new MemoryStream())
            {

                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, list);
                ms.Position = 0;
                byte[] buffer = new byte[(int)ms.Length];
                ms.Read(buffer, 0, buffer.Length);
                File.WriteAllText("PackingCost.conf", Convert.ToBase64String(buffer));
                File.Exists("PackingCost.conf");


            }
        }
        public static void SaveColorCost( List<ColorCost> list)
        {

            using (MemoryStream ms = new MemoryStream())
            {

                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, list);
                ms.Position = 0;
                byte[] buffer = new byte[(int)ms.Length];
                ms.Read(buffer, 0, buffer.Length);
                File.WriteAllText("ColorCost.conf", Convert.ToBase64String(buffer));
                File.Exists("ColorCost.conf");


            }
        }
        public static List<PackingCost> LoadPackingCost()
        {

            List<PackingCost> list ;
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(File.ReadAllText("PackingCost.conf"))))
            {
                BinaryFormatter bf = new BinaryFormatter();
                list = (List<PackingCost>)bf.Deserialize(ms);
            }
            return list;
        }
        public static List<ColorCost> LoadColorCost()
        {

            List<ColorCost> list;
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(File.ReadAllText("ColorCost.conf"))))
            {
                BinaryFormatter bf = new BinaryFormatter();
                list = (List<ColorCost>)bf.Deserialize(ms);
            }
            return list;
        }
    }
   
}
