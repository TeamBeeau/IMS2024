using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
    [StandardModule]
    [HideModuleName]
    [GeneratedCode("MyTemplate", "11.0.0.0")]
    internal sealed class MyProject
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
        internal sealed class MyForms
        {
            [ThreadStatic]
            private static Hashtable m_FormBeingCreated;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public CRViewer m_CRViewer;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmINEADJ m_frmINEADJ;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmINESTG m_frmINESTG;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmINESTK m_frmINESTK;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmINETRF m_frmINETRF;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmINQBAL m_frmINQBAL;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmINQLOT m_frmINQLOT;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmINRIRA m_frmINRIRA;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmINRLED m_frmINRLED;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmINRSTS m_frmINRSTS;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmITE2HQ m_frmITE2HQ;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmITE2SC m_frmITE2SC;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmLM1BAK m_frmLM1BAK;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmLM1EMS m_frmLM1EMS;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmLM1GRP m_frmLM1GRP;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmLM1PRG m_frmLM1PRG;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmLM1PRGX m_frmLM1PRGX;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmLM1SYS m_frmLM1SYS;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmLM1USR m_frmLM1USR;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmLM1XCS m_frmLM1XCS;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmLookup m_frmLookup;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMA1CTL m_frmMA1CTL;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAEBDM m_frmMAEBDM;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAEBOM m_frmMAEBOM;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAECAL m_frmMAECAL;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAECBOM m_frmMAECBOM;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAECDT m_frmMAECDT;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAECOD m_frmMAECOD;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAECTY m_frmMAECTY;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAECUR m_frmMAECUR;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAECUS m_frmMAECUS;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAEDEL m_frmMAEDEL;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAEITM m_frmMAEITM;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAELGG m_frmMAELGG;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAELOC m_frmMAELOC;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAEMCH m_frmMAEMCH;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAEMSG m_frmMAEMSG;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAENUM m_frmMAENUM;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAEPAL m_frmMAEPAL;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAEPLT m_frmMAEPLT;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAEPPR m_frmMAEPPR;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAEROU m_frmMAEROU;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAESPR m_frmMAESPR;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAESUP m_frmMAESUP;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAMCAL m_frmMAMCAL;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAPITM_BAR m_frmMAPITM_BAR;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMAQBOM m_frmMAQBOM;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPCEGRN m_frmPCEGRN;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPCELOTDSP m_frmPCELOTDSP;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPCEMPS m_frmPCEMPS;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPCEPAW m_frmPCEPAW;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPCEPCO m_frmPCEPCO;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPCERTF m_frmPCERTF;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPCERTN m_frmPCERTN;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPCLGRL m_frmPCLGRL;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPCQPCO m_frmPCQPCO;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPCQPOS m_frmPCQPOS;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPCRORB m_frmPCRORB;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPCRPCO m_frmPCRPCO;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPCRPPO m_frmPCRPPO;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPCXMRP m_frmPCXMRP;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPDEFGR m_frmPDEFGR;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPDEFGRWO m_frmPDEFGRWO;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPDELOTDSP m_frmPDELOTDSP;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPDEPIS m_frmPDEPIS;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPDEPRQ m_frmPDEPRQ;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPDERDO m_frmPDERDO;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPDERFG m_frmPDERFG;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPDERWO m_frmPDERWO;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPDESFR m_frmPDESFR;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPDESWOR m_frmPDESWOR;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPDEWKB m_frmPDEWKB;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPDEWKO m_frmPDEWKO;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPDEWOR m_frmPDEWOR;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPDLWKO m_frmPDLWKO;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPDQWKO m_frmPDQWKO;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPDRFGL m_frmPDRFGL;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPDRPRD m_frmPDRPRD;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPDRWIPL m_frmPDRWIPL;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmQOECQO m_frmQOECQO;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmQOEPRC m_frmQOEPRC;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmSLESDR m_frmSLESDR;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmSLQSLO m_frmSLQSLO;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmSLRORD m_frmSLRORD;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmSSEINV m_frmSSEINV;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmSSEORD m_frmSSEORD;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmSSESHP m_frmSSESHP;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmSSLDLO m_frmSSLDLO;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmSSLORD m_frmSSLORD;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmULRSVD m_frmULRSVD;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmULXCST m_frmULXCST;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmXDTACC m_frmXDTACC;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Login m_Login;

            [EditorBrowsable(EditorBrowsableState.Never)]
            public MDIParent m_MDIParent;

            public CRViewer CRViewer
            {
                [DebuggerHidden]
                get
                {
                    m_CRViewer = Create__Instance__(m_CRViewer);
                    return m_CRViewer;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_CRViewer)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_CRViewer);
                    }
                }
            }

            public frmINEADJ frmINEADJ
            {
                [DebuggerHidden]
                get
                {
                    m_frmINEADJ = Create__Instance__(m_frmINEADJ);
                    return m_frmINEADJ;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmINEADJ)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmINEADJ);
                    }
                }
            }

            public frmINESTG frmINESTG
            {
                [DebuggerHidden]
                get
                {
                    m_frmINESTG = Create__Instance__(m_frmINESTG);
                    return m_frmINESTG;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmINESTG)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmINESTG);
                    }
                }
            }

            public frmINESTK frmINESTK
            {
                [DebuggerHidden]
                get
                {
                    m_frmINESTK = Create__Instance__(m_frmINESTK);
                    return m_frmINESTK;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmINESTK)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmINESTK);
                    }
                }
            }

            public frmINETRF frmINETRF
            {
                [DebuggerHidden]
                get
                {
                    m_frmINETRF = Create__Instance__(m_frmINETRF);
                    return m_frmINETRF;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmINETRF)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmINETRF);
                    }
                }
            }

            public frmINQBAL frmINQBAL
            {
                [DebuggerHidden]
                get
                {
                    m_frmINQBAL = Create__Instance__(m_frmINQBAL);
                    return m_frmINQBAL;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmINQBAL)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmINQBAL);
                    }
                }
            }

            public frmINQLOT frmINQLOT
            {
                [DebuggerHidden]
                get
                {
                    m_frmINQLOT = Create__Instance__(m_frmINQLOT);
                    return m_frmINQLOT;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmINQLOT)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmINQLOT);
                    }
                }
            }

            public frmINRIRA frmINRIRA
            {
                [DebuggerHidden]
                get
                {
                    m_frmINRIRA = Create__Instance__(m_frmINRIRA);
                    return m_frmINRIRA;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmINRIRA)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmINRIRA);
                    }
                }
            }

            public frmINRLED frmINRLED
            {
                [DebuggerHidden]
                get
                {
                    m_frmINRLED = Create__Instance__(m_frmINRLED);
                    return m_frmINRLED;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmINRLED)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmINRLED);
                    }
                }
            }

            public frmINRSTS frmINRSTS
            {
                [DebuggerHidden]
                get
                {
                    m_frmINRSTS = Create__Instance__(m_frmINRSTS);
                    return m_frmINRSTS;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmINRSTS)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmINRSTS);
                    }
                }
            }

            public frmITE2HQ frmITE2HQ
            {
                [DebuggerHidden]
                get
                {
                    m_frmITE2HQ = Create__Instance__(m_frmITE2HQ);
                    return m_frmITE2HQ;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmITE2HQ)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmITE2HQ);
                    }
                }
            }

            public frmITE2SC frmITE2SC
            {
                [DebuggerHidden]
                get
                {
                    m_frmITE2SC = Create__Instance__(m_frmITE2SC);
                    return m_frmITE2SC;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmITE2SC)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmITE2SC);
                    }
                }
            }

            public frmLM1BAK frmLM1BAK
            {
                [DebuggerHidden]
                get
                {
                    m_frmLM1BAK = Create__Instance__(m_frmLM1BAK);
                    return m_frmLM1BAK;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmLM1BAK)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmLM1BAK);
                    }
                }
            }

            public frmLM1EMS frmLM1EMS
            {
                [DebuggerHidden]
                get
                {
                    m_frmLM1EMS = Create__Instance__(m_frmLM1EMS);
                    return m_frmLM1EMS;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmLM1EMS)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmLM1EMS);
                    }
                }
            }

            public frmLM1GRP frmLM1GRP
            {
                [DebuggerHidden]
                get
                {
                    m_frmLM1GRP = Create__Instance__(m_frmLM1GRP);
                    return m_frmLM1GRP;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmLM1GRP)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmLM1GRP);
                    }
                }
            }

            public frmLM1PRG frmLM1PRG
            {
                [DebuggerHidden]
                get
                {
                    m_frmLM1PRG = Create__Instance__(m_frmLM1PRG);
                    return m_frmLM1PRG;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmLM1PRG)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmLM1PRG);
                    }
                }
            }

            public frmLM1PRGX frmLM1PRGX
            {
                [DebuggerHidden]
                get
                {
                    m_frmLM1PRGX = Create__Instance__(m_frmLM1PRGX);
                    return m_frmLM1PRGX;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmLM1PRGX)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmLM1PRGX);
                    }
                }
            }

            public frmLM1SYS frmLM1SYS
            {
                [DebuggerHidden]
                get
                {
                    m_frmLM1SYS = Create__Instance__(m_frmLM1SYS);
                    return m_frmLM1SYS;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmLM1SYS)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmLM1SYS);
                    }
                }
            }

            public frmLM1USR frmLM1USR
            {
                [DebuggerHidden]
                get
                {
                    m_frmLM1USR = Create__Instance__(m_frmLM1USR);
                    return m_frmLM1USR;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmLM1USR)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmLM1USR);
                    }
                }
            }

            public frmLM1XCS frmLM1XCS
            {
                [DebuggerHidden]
                get
                {
                    m_frmLM1XCS = Create__Instance__(m_frmLM1XCS);
                    return m_frmLM1XCS;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmLM1XCS)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmLM1XCS);
                    }
                }
            }

            public frmLookup frmLookup
            {
                [DebuggerHidden]
                get
                {
                    m_frmLookup = Create__Instance__(m_frmLookup);
                    return m_frmLookup;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmLookup)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmLookup);
                    }
                }
            }

            public frmMA1CTL frmMA1CTL
            {
                [DebuggerHidden]
                get
                {
                    m_frmMA1CTL = Create__Instance__(m_frmMA1CTL);
                    return m_frmMA1CTL;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMA1CTL)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMA1CTL);
                    }
                }
            }

            public frmMAEBDM frmMAEBDM
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAEBDM = Create__Instance__(m_frmMAEBDM);
                    return m_frmMAEBDM;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAEBDM)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAEBDM);
                    }
                }
            }

            public frmMAEBOM frmMAEBOM
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAEBOM = Create__Instance__(m_frmMAEBOM);
                    return m_frmMAEBOM;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAEBOM)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAEBOM);
                    }
                }
            }

            public frmMAECAL frmMAECAL
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAECAL = Create__Instance__(m_frmMAECAL);
                    return m_frmMAECAL;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAECAL)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAECAL);
                    }
                }
            }

            public frmMAECBOM frmMAECBOM
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAECBOM = Create__Instance__(m_frmMAECBOM);
                    return m_frmMAECBOM;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAECBOM)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAECBOM);
                    }
                }
            }

            public frmMAECDT frmMAECDT
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAECDT = Create__Instance__(m_frmMAECDT);
                    return m_frmMAECDT;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAECDT)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAECDT);
                    }
                }
            }

            public frmMAECOD frmMAECOD
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAECOD = Create__Instance__(m_frmMAECOD);
                    return m_frmMAECOD;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAECOD)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAECOD);
                    }
                }
            }

            public frmMAECTY frmMAECTY
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAECTY = Create__Instance__(m_frmMAECTY);
                    return m_frmMAECTY;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAECTY)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAECTY);
                    }
                }
            }

            public frmMAECUR frmMAECUR
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAECUR = Create__Instance__(m_frmMAECUR);
                    return m_frmMAECUR;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAECUR)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAECUR);
                    }
                }
            }

            public frmMAECUS frmMAECUS
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAECUS = Create__Instance__(m_frmMAECUS);
                    return m_frmMAECUS;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAECUS)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAECUS);
                    }
                }
            }

            public frmMAEDEL frmMAEDEL
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAEDEL = Create__Instance__(m_frmMAEDEL);
                    return m_frmMAEDEL;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAEDEL)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAEDEL);
                    }
                }
            }

            public frmMAEITM frmMAEITM
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAEITM = Create__Instance__(m_frmMAEITM);
                    return m_frmMAEITM;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAEITM)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAEITM);
                    }
                }
            }

            public frmMAELGG frmMAELGG
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAELGG = Create__Instance__(m_frmMAELGG);
                    return m_frmMAELGG;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAELGG)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAELGG);
                    }
                }
            }

            public frmMAELOC frmMAELOC
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAELOC = Create__Instance__(m_frmMAELOC);
                    return m_frmMAELOC;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAELOC)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAELOC);
                    }
                }
            }

            public frmMAEMCH frmMAEMCH
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAEMCH = Create__Instance__(m_frmMAEMCH);
                    return m_frmMAEMCH;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAEMCH)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAEMCH);
                    }
                }
            }

            public frmMAEMSG frmMAEMSG
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAEMSG = Create__Instance__(m_frmMAEMSG);
                    return m_frmMAEMSG;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAEMSG)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAEMSG);
                    }
                }
            }

            public frmMAENUM frmMAENUM
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAENUM = Create__Instance__(m_frmMAENUM);
                    return m_frmMAENUM;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAENUM)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAENUM);
                    }
                }
            }

            public frmMAEPAL frmMAEPAL
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAEPAL = Create__Instance__(m_frmMAEPAL);
                    return m_frmMAEPAL;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAEPAL)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAEPAL);
                    }
                }
            }

            public frmMAEPLT frmMAEPLT
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAEPLT = Create__Instance__(m_frmMAEPLT);
                    return m_frmMAEPLT;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAEPLT)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAEPLT);
                    }
                }
            }

            public frmMAEPPR frmMAEPPR
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAEPPR = Create__Instance__(m_frmMAEPPR);
                    return m_frmMAEPPR;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAEPPR)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAEPPR);
                    }
                }
            }

            public frmMAEROU frmMAEROU
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAEROU = Create__Instance__(m_frmMAEROU);
                    return m_frmMAEROU;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAEROU)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAEROU);
                    }
                }
            }

            public frmMAESPR frmMAESPR
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAESPR = Create__Instance__(m_frmMAESPR);
                    return m_frmMAESPR;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAESPR)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAESPR);
                    }
                }
            }

            public frmMAESUP frmMAESUP
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAESUP = Create__Instance__(m_frmMAESUP);
                    return m_frmMAESUP;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAESUP)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAESUP);
                    }
                }
            }

            public frmMAMCAL frmMAMCAL
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAMCAL = Create__Instance__(m_frmMAMCAL);
                    return m_frmMAMCAL;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAMCAL)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAMCAL);
                    }
                }
            }

            public frmMAPITM_BAR frmMAPITM_BAR
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAPITM_BAR = Create__Instance__(m_frmMAPITM_BAR);
                    return m_frmMAPITM_BAR;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAPITM_BAR)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAPITM_BAR);
                    }
                }
            }

            public frmMAQBOM frmMAQBOM
            {
                [DebuggerHidden]
                get
                {
                    m_frmMAQBOM = Create__Instance__(m_frmMAQBOM);
                    return m_frmMAQBOM;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmMAQBOM)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMAQBOM);
                    }
                }
            }

            public frmPCEGRN frmPCEGRN
            {
                [DebuggerHidden]
                get
                {
                    m_frmPCEGRN = Create__Instance__(m_frmPCEGRN);
                    return m_frmPCEGRN;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPCEGRN)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPCEGRN);
                    }
                }
            }

            public frmPCELOTDSP frmPCELOTDSP
            {
                [DebuggerHidden]
                get
                {
                    m_frmPCELOTDSP = Create__Instance__(m_frmPCELOTDSP);
                    return m_frmPCELOTDSP;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPCELOTDSP)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPCELOTDSP);
                    }
                }
            }

            public frmPCEMPS frmPCEMPS
            {
                [DebuggerHidden]
                get
                {
                    m_frmPCEMPS = Create__Instance__(m_frmPCEMPS);
                    return m_frmPCEMPS;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPCEMPS)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPCEMPS);
                    }
                }
            }

            public frmPCEPAW frmPCEPAW
            {
                [DebuggerHidden]
                get
                {
                    m_frmPCEPAW = Create__Instance__(m_frmPCEPAW);
                    return m_frmPCEPAW;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPCEPAW)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPCEPAW);
                    }
                }
            }

            public frmPCEPCO frmPCEPCO
            {
                [DebuggerHidden]
                get
                {
                    m_frmPCEPCO = Create__Instance__(m_frmPCEPCO);
                    return m_frmPCEPCO;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPCEPCO)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPCEPCO);
                    }
                }
            }

            public frmPCERTF frmPCERTF
            {
                [DebuggerHidden]
                get
                {
                    m_frmPCERTF = Create__Instance__(m_frmPCERTF);
                    return m_frmPCERTF;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPCERTF)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPCERTF);
                    }
                }
            }

            public frmPCERTN frmPCERTN
            {
                [DebuggerHidden]
                get
                {
                    m_frmPCERTN = Create__Instance__(m_frmPCERTN);
                    return m_frmPCERTN;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPCERTN)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPCERTN);
                    }
                }
            }

            public frmPCLGRL frmPCLGRL
            {
                [DebuggerHidden]
                get
                {
                    m_frmPCLGRL = Create__Instance__(m_frmPCLGRL);
                    return m_frmPCLGRL;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPCLGRL)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPCLGRL);
                    }
                }
            }

            public frmPCQPCO frmPCQPCO
            {
                [DebuggerHidden]
                get
                {
                    m_frmPCQPCO = Create__Instance__(m_frmPCQPCO);
                    return m_frmPCQPCO;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPCQPCO)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPCQPCO);
                    }
                }
            }

            public frmPCQPOS frmPCQPOS
            {
                [DebuggerHidden]
                get
                {
                    m_frmPCQPOS = Create__Instance__(m_frmPCQPOS);
                    return m_frmPCQPOS;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPCQPOS)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPCQPOS);
                    }
                }
            }

            public frmPCRORB frmPCRORB
            {
                [DebuggerHidden]
                get
                {
                    m_frmPCRORB = Create__Instance__(m_frmPCRORB);
                    return m_frmPCRORB;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPCRORB)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPCRORB);
                    }
                }
            }

            public frmPCRPCO frmPCRPCO
            {
                [DebuggerHidden]
                get
                {
                    m_frmPCRPCO = Create__Instance__(m_frmPCRPCO);
                    return m_frmPCRPCO;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPCRPCO)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPCRPCO);
                    }
                }
            }

            public frmPCRPPO frmPCRPPO
            {
                [DebuggerHidden]
                get
                {
                    m_frmPCRPPO = Create__Instance__(m_frmPCRPPO);
                    return m_frmPCRPPO;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPCRPPO)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPCRPPO);
                    }
                }
            }

            public frmPCXMRP frmPCXMRP
            {
                [DebuggerHidden]
                get
                {
                    m_frmPCXMRP = Create__Instance__(m_frmPCXMRP);
                    return m_frmPCXMRP;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPCXMRP)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPCXMRP);
                    }
                }
            }

            public frmPDEFGR frmPDEFGR
            {
                [DebuggerHidden]
                get
                {
                    m_frmPDEFGR = Create__Instance__(m_frmPDEFGR);
                    return m_frmPDEFGR;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPDEFGR)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPDEFGR);
                    }
                }
            }

            public frmPDEFGRWO frmPDEFGRWO
            {
                [DebuggerHidden]
                get
                {
                    m_frmPDEFGRWO = Create__Instance__(m_frmPDEFGRWO);
                    return m_frmPDEFGRWO;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPDEFGRWO)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPDEFGRWO);
                    }
                }
            }

            public frmPDELOTDSP frmPDELOTDSP
            {
                [DebuggerHidden]
                get
                {
                    m_frmPDELOTDSP = Create__Instance__(m_frmPDELOTDSP);
                    return m_frmPDELOTDSP;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPDELOTDSP)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPDELOTDSP);
                    }
                }
            }

            public frmPDEPIS frmPDEPIS
            {
                [DebuggerHidden]
                get
                {
                    m_frmPDEPIS = Create__Instance__(m_frmPDEPIS);
                    return m_frmPDEPIS;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPDEPIS)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPDEPIS);
                    }
                }
            }

            public frmPDEPRQ frmPDEPRQ
            {
                [DebuggerHidden]
                get
                {
                    m_frmPDEPRQ = Create__Instance__(m_frmPDEPRQ);
                    return m_frmPDEPRQ;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPDEPRQ)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPDEPRQ);
                    }
                }
            }

            public frmPDERDO frmPDERDO
            {
                [DebuggerHidden]
                get
                {
                    m_frmPDERDO = Create__Instance__(m_frmPDERDO);
                    return m_frmPDERDO;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPDERDO)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPDERDO);
                    }
                }
            }

            public frmPDERFG frmPDERFG
            {
                [DebuggerHidden]
                get
                {
                    m_frmPDERFG = Create__Instance__(m_frmPDERFG);
                    return m_frmPDERFG;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPDERFG)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPDERFG);
                    }
                }
            }

            public frmPDERWO frmPDERWO
            {
                [DebuggerHidden]
                get
                {
                    m_frmPDERWO = Create__Instance__(m_frmPDERWO);
                    return m_frmPDERWO;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPDERWO)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPDERWO);
                    }
                }
            }

            public frmPDESFR frmPDESFR
            {
                [DebuggerHidden]
                get
                {
                    m_frmPDESFR = Create__Instance__(m_frmPDESFR);
                    return m_frmPDESFR;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPDESFR)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPDESFR);
                    }
                }
            }

            public frmPDESWOR frmPDESWOR
            {
                [DebuggerHidden]
                get
                {
                    m_frmPDESWOR = Create__Instance__(m_frmPDESWOR);
                    return m_frmPDESWOR;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPDESWOR)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPDESWOR);
                    }
                }
            }

            public frmPDEWKB frmPDEWKB
            {
                [DebuggerHidden]
                get
                {
                    m_frmPDEWKB = Create__Instance__(m_frmPDEWKB);
                    return m_frmPDEWKB;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPDEWKB)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPDEWKB);
                    }
                }
            }

            public frmPDEWKO frmPDEWKO
            {
                [DebuggerHidden]
                get
                {
                    m_frmPDEWKO = Create__Instance__(m_frmPDEWKO);
                    return m_frmPDEWKO;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPDEWKO)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPDEWKO);
                    }
                }
            }

            public frmPDEWOR frmPDEWOR
            {
                [DebuggerHidden]
                get
                {
                    m_frmPDEWOR = Create__Instance__(m_frmPDEWOR);
                    return m_frmPDEWOR;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPDEWOR)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPDEWOR);
                    }
                }
            }

            public frmPDLWKO frmPDLWKO
            {
                [DebuggerHidden]
                get
                {
                    m_frmPDLWKO = Create__Instance__(m_frmPDLWKO);
                    return m_frmPDLWKO;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPDLWKO)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPDLWKO);
                    }
                }
            }

            public frmPDQWKO frmPDQWKO
            {
                [DebuggerHidden]
                get
                {
                    m_frmPDQWKO = Create__Instance__(m_frmPDQWKO);
                    return m_frmPDQWKO;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPDQWKO)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPDQWKO);
                    }
                }
            }

            public frmPDRFGL frmPDRFGL
            {
                [DebuggerHidden]
                get
                {
                    m_frmPDRFGL = Create__Instance__(m_frmPDRFGL);
                    return m_frmPDRFGL;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPDRFGL)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPDRFGL);
                    }
                }
            }

            public frmPDRPRD frmPDRPRD
            {
                [DebuggerHidden]
                get
                {
                    m_frmPDRPRD = Create__Instance__(m_frmPDRPRD);
                    return m_frmPDRPRD;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPDRPRD)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPDRPRD);
                    }
                }
            }

            public frmPDRWIPL frmPDRWIPL
            {
                [DebuggerHidden]
                get
                {
                    m_frmPDRWIPL = Create__Instance__(m_frmPDRWIPL);
                    return m_frmPDRWIPL;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmPDRWIPL)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmPDRWIPL);
                    }
                }
            }

            public frmQOECQO frmQOECQO
            {
                [DebuggerHidden]
                get
                {
                    m_frmQOECQO = Create__Instance__(m_frmQOECQO);
                    return m_frmQOECQO;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmQOECQO)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmQOECQO);
                    }
                }
            }

            public frmQOEPRC frmQOEPRC
            {
                [DebuggerHidden]
                get
                {
                    m_frmQOEPRC = Create__Instance__(m_frmQOEPRC);
                    return m_frmQOEPRC;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmQOEPRC)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmQOEPRC);
                    }
                }
            }

            public frmSLESDR frmSLESDR
            {
                [DebuggerHidden]
                get
                {
                    m_frmSLESDR = Create__Instance__(m_frmSLESDR);
                    return m_frmSLESDR;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmSLESDR)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmSLESDR);
                    }
                }
            }

            public frmSLQSLO frmSLQSLO
            {
                [DebuggerHidden]
                get
                {
                    m_frmSLQSLO = Create__Instance__(m_frmSLQSLO);
                    return m_frmSLQSLO;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmSLQSLO)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmSLQSLO);
                    }
                }
            }

            public frmSLRORD frmSLRORD
            {
                [DebuggerHidden]
                get
                {
                    m_frmSLRORD = Create__Instance__(m_frmSLRORD);
                    return m_frmSLRORD;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmSLRORD)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmSLRORD);
                    }
                }
            }

            public frmSSEINV frmSSEINV
            {
                [DebuggerHidden]
                get
                {
                    m_frmSSEINV = Create__Instance__(m_frmSSEINV);
                    return m_frmSSEINV;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmSSEINV)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmSSEINV);
                    }
                }
            }

            public frmSSEORD frmSSEORD
            {
                [DebuggerHidden]
                get
                {
                    m_frmSSEORD = Create__Instance__(m_frmSSEORD);
                    return m_frmSSEORD;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmSSEORD)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmSSEORD);
                    }
                }
            }

            public frmSSESHP frmSSESHP
            {
                [DebuggerHidden]
                get
                {
                    m_frmSSESHP = Create__Instance__(m_frmSSESHP);
                    return m_frmSSESHP;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmSSESHP)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmSSESHP);
                    }
                }
            }

            public frmSSLDLO frmSSLDLO
            {
                [DebuggerHidden]
                get
                {
                    m_frmSSLDLO = Create__Instance__(m_frmSSLDLO);
                    return m_frmSSLDLO;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmSSLDLO)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmSSLDLO);
                    }
                }
            }

            public frmSSLORD frmSSLORD
            {
                [DebuggerHidden]
                get
                {
                    m_frmSSLORD = Create__Instance__(m_frmSSLORD);
                    return m_frmSSLORD;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmSSLORD)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmSSLORD);
                    }
                }
            }

            public frmULRSVD frmULRSVD
            {
                [DebuggerHidden]
                get
                {
                    m_frmULRSVD = Create__Instance__(m_frmULRSVD);
                    return m_frmULRSVD;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmULRSVD)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmULRSVD);
                    }
                }
            }

            public frmULXCST frmULXCST
            {
                [DebuggerHidden]
                get
                {
                    m_frmULXCST = Create__Instance__(m_frmULXCST);
                    return m_frmULXCST;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmULXCST)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmULXCST);
                    }
                }
            }

            public frmXDTACC frmXDTACC
            {
                [DebuggerHidden]
                get
                {
                    m_frmXDTACC = Create__Instance__(m_frmXDTACC);
                    return m_frmXDTACC;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_frmXDTACC)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmXDTACC);
                    }
                }
            }

            public Login Login
            {
                [DebuggerHidden]
                get
                {
                    m_Login = Create__Instance__(m_Login);
                    return m_Login;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_Login)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_Login);
                    }
                }
            }

            public MDIParent MDIParent
            {
                [DebuggerHidden]
                get
                {
                    m_MDIParent = Create__Instance__(m_MDIParent);
                    return m_MDIParent;
                }
                [DebuggerHidden]
                set
                {
                    if (value != m_MDIParent)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_MDIParent);
                    }
                }
            }

            [DebuggerHidden]
            private static T Create__Instance__<T>(T Instance) where T : Form, new()
            {
                if (Instance == null || Instance.IsDisposed)
                {
                    if (m_FormBeingCreated != null)
                    {
                        if (m_FormBeingCreated.ContainsKey(typeof(T)))
                        {
                            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
                        }
                    }
                    else
                    {
                        m_FormBeingCreated = new Hashtable();
                    }
                    m_FormBeingCreated.Add(typeof(T), null);
                    try
                    {
                        return new T();
                    }
                    catch (TargetInvocationException ex) when (((Func<bool>)delegate
                    {
                        // Could not convert BlockContainer to single expression
                        ProjectData.SetProjectError(ex);
                        return ex.InnerException != null;
                    }).Invoke())
                    {
                        string BetterMessage = Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message);
                        throw new InvalidOperationException(BetterMessage, ex.InnerException);
                    }
                    finally
                    {
                        m_FormBeingCreated.Remove(typeof(T));
                    }
                }
                return Instance;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance) where T : Form
            {
                instance.Dispose();
                instance = null;
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public MyForms()
            {
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o)
            {
                return base.Equals(RuntimeHelpers.GetObjectValue(o));
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            internal new Type GetType()
            {
                return typeof(MyForms);
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString()
            {
                return base.ToString();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
        internal sealed class MyWebServices
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            [DebuggerHidden]
            public override bool Equals(object o)
            {
                return base.Equals(RuntimeHelpers.GetObjectValue(o));
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            [DebuggerHidden]
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            [DebuggerHidden]
            internal new Type GetType()
            {
                return typeof(MyWebServices);
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            [DebuggerHidden]
            public override string ToString()
            {
                return base.ToString();
            }

            [DebuggerHidden]
            private static T Create__Instance__<T>(T instance) where T : new()
            {
                if (instance == null)
                {
                    return new T();
                }
                return instance;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance)
            {
                instance = default(T);
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public MyWebServices()
            {
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [ComVisible(false)]
        internal sealed class ThreadSafeObjectProvider<T> where T : new()
        {
            [CompilerGenerated]
            [ThreadStatic]
            private static T m_ThreadStaticValue;

            internal T GetInstance
            {
                [DebuggerHidden]
                get
                {
                    if (m_ThreadStaticValue == null)
                    {
                        m_ThreadStaticValue = new T();
                    }
                    return m_ThreadStaticValue;
                }
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public ThreadSafeObjectProvider()
            {
            }
        }

        private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

        private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

        private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

        private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

        private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

        [HelpKeyword("My.Computer")]
        internal static MyComputer Computer
        {
            [DebuggerHidden]
            get
            {
                return m_ComputerObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.Application")]
        internal static MyApplication Application
        {
            [DebuggerHidden]
            get
            {
                return m_AppObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.User")]
        internal static User User
        {
            [DebuggerHidden]
            get
            {
                return m_UserObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.Forms")]
        internal static MyForms Forms
        {
            [DebuggerHidden]
            get
            {
                return m_MyFormsObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.WebServices")]
        internal static MyWebServices WebServices
        {
            [DebuggerHidden]
            get
            {
                return m_MyWebServicesObjectProvider.GetInstance;
            }
        }
    }
}
