using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	[StandardModule]
	internal sealed class Message
	{
		public const string MSG_DBSERVER_NOT_FOUND = "System can not locate database! Please contact system administrator.";

		public const string MSG_LOGIN_FAIL = "System failed to login! Please contact system administrator.";

		public const string MSG_CONN_INFO_NOT_SET = "Database connection info. not properly setup! Please contact system administrator.";

		public const string MSG_TABLEOBJ_FAIL = "Unable to create table object! Please contact system administrator.";

		public const string MSG_COLUMNOBJ_FAIL = "Unable to create column object! Please contact system administrator.";

		public const string MSG_LOADAUTONUM_FAIL = "Unable to load auto number information! Please contact your software vendor.";

		public const string MSG_SAVEAUTONUM_FAIL = "Unable to save auto number information! Please contact your software vendor.";

		public const string coErr_AppStart = "Application already started!";

		public const string coErr_ClsFailed = "Class initialization failed!";

		public const string coErr_Control = "Control table not set. Application terminated!";

		public const string coErr_LoadCls = "Unable to create class object. Application terminated!";

		public const string coErr_ContactVendor = "Unable to save company information! Please contact your software vendor.";

		public const string coErr_LoadCompany = "Unable to load company information! Please contact your software vendor.";

		public const string coErr_SaveCompany = "Unable to save company information! Please contact your software vendor.";

		public const string coErr_LoadSystem = "Unable to load system information! Please contact your software vendor.";

		public const string coErr_SaveSystem = "Unable to save system information! Please contact your software vendor.";

		public const string coErr_LoadUser = "Unable to load user information! Please contact your software vendor.";

		public const string coErr_SaveUser = "Unable to save user information! Please contact your software vendor.";

		public const string coErr_DeleteUser = "Unable to delete user information! Please contact your software vendor.";

		public const string coErr_LoadCust = "Unable to load customer information! Please contact your software vendor.";

		public const string coErr_SaveCust = "Unable to save customer information! Please contact your software vendor.";

		public const string coErr_DeleteCust = "Unable to delete customer information! Please contact your software vendor.";

		public const string coErr_LoadSupp = "Unable to load supplier information! Please contact your software vendor.";

		public const string coErr_SaveSupp = "Unable to save supplier information! Please contact your software vendor.";

		public const string coErr_DeleteSupp = "Unable to delete supplier information! Please contact your software vendor.";

		public const string coErr_LoadItem = "Unable to load item information! Please contact your software vendor.";

		public const string coErr_SaveItem = "Unable to save item information! Please contact your software vendor.";

		public const string coErr_DeleteItem = "Unable to delete item information! Please contact your software vendor.";

		public const string coErr_LoadPack = "Unable to load package information! Please contact your software vendor.";

		public const string coErr_SavePack = "Unable to save package information! Please contact your software vendor.";

		public const string coErr_DeletePack = "Unable to delete package information! Please contact your software vendor.";

		public const string coErr_LoadServ = "Unable to load service information! Please contact your software vendor.";

		public const string coErr_SaveServ = "Unable to save service information! Please contact your software vendor.";

		public const string coErr_DeleteServ = "Unable to delete service information! Please contact your software vendor.";

		public const string coErr_LoadPUPRC = "Unable to load purchase price information! Please contact your software vendor.";

		public const string coErr_SavePUPRC = "Unable to save purchase price information! Please contact your software vendor.";

		public const string coErr_DeletePUPRC = "Unable to delete purchase price information! Please contact your software vendor.";

		public const string coErr_LoadCodTy = "Unable to load code type information! Please contact your software vendor.";

		public const string coErr_SaveCodTy = "Unable to save code type information! Please contact your software vendor.";

		public const string coErr_DeleteCodTy = "Unable to delete code type information! Please contact your software vendor.";

		public const string coErr_LoadCode = "Unable to load code information! Please contact your software vendor.";

		public const string coErr_SaveCode = "Unable to save code information! Please contact your software vendor.";

		public const string coErr_DeleteCode = "Unable to delete code information! Please contact your software vendor.";

		public const string coErr_LoadMaker = "Unable to load car maker information! Please contact your software vendor.";

		public const string coErr_SaveMaker = "Unable to save car maker information! Please contact your software vendor.";

		public const string coErr_DeleteMaker = "Unable to delete car maker information! Please contact your software vendor.";

		public const string coErr_LoadCarModel = "Unable to load car model information! Please contact your software vendor.";

		public const string coErr_SaveCarModel = "Unable to save car model information! Please contact your software vendor.";

		public const string coErr_DeleteCarModel = "Unable to delete car model information! Please contact your software vendor.";

		public const string coErr_LoadCarService = "Unable to load car service information! Please contact your software vendor.";

		public const string coErr_SaveCarService = "Unable to save car service information! Please contact your software vendor.";

		public const string coErr_DeleteCarService = "Unable to delete car service information! Please contact your software vendor.";

		public const string coErr_LoadJobHeader = "Unable to load job header information! Please contact your software vendor.";

		public const string coErr_SaveJobHeader = "Unable to save job header information! Please contact your software vendor.";

		public const string coErr_DeleteJobHeader = "Unable to delete job header information! Please contact your software vendor.";

		public const string coErr_LoadInvoice = "Unable to load invoice information! Please contact your software vendor.";

		public const string coErr_SaveInvoice = "Unable to save invoice information! Please contact your software vendor.";

		public const string coErr_DeleteInvoice = "Unable to delete invoice information! Please contact your software vendor.";

		public const string coErr_LoadPayment = "Unable to load payment information! Please contact your software vendor.";

		public const string coErr_SavePayment = "Unable to save payment information! Please contact your software vendor.";

		public const string coErr_DeletePayment = "Unable to delete payment information! Please contact your software vendor.";

		public const string coErr_LoadGRN = "Unable to load Stock In information! Please contact your software vendor.";

		public const string coErr_SaveGRN = "Unable to save Stock In information! Please contact your software vendor.";

		public const string coErr_DeleteGRN = "Unable to delete Stock In information! Please contact your software vendor.";

		public const string coErr_LoadGRNCFM = "Unable to load Stock In Confirmation information! Please contact your software vendor.";

		public const string coErr_SaveGRNCFM = "Unable to save Stock In Confirmation information! Please contact your software vendor.";

		public const string coErr_LoadStkBal = "Unable to load inventory balance information! Please contact your software vendor.";

		public const string coErr_SaveStkBal = "Unable to save inventory balance information! Please contact your software vendor.";

		public const string coErr_LoadTransaction = "Unable to load transaction information! Please contact your software vendor.";

		public const string coErr_SaveTransaction = "Unable to save transaction information! Please contact your software vendor.";

		public const string coErr_LoadLedger = "Unable to load Stock Ledger information! Please contact your software vendor.";

		public const string coErr_SaveLedger = "Unable to save Stock Ledger information! Please contact your software vendor.";

		public const string coErr_LoadPSRV = "Unable to load Supplier Service information! Please contact your software vendor.";

		public const string coErr_SavePSRV = "Unable to save Supplier Service information! Please contact your software vendor.";

		public const string coErr_DeletePSRV = "Unable to delete Supplier Service information! Please contact your software vendor.";

		public const string coErr_LoadPINV = "Unable to load Supplier Invoice information! Please contact your software vendor.";

		public const string coErr_SavePINV = "Unable to save Supplier Invoice information! Please contact your software vendor.";

		public const string coErr_DeletePINV = "Unable to delete Supplier Invoice information! Please contact your software vendor.";

		public const string coErr_User = "Invalid user!";

		public const string coErr_Password = "Invalid password!";

		public const string coErr_Logon = "System logon failed!";

		public const string coErr_UserLogon = "User already logon!";

		public const string coErr_DelAdmin = "Cannot delete Admin user!";

		public const string coErr_FunctionNotAllow = "This function is not allow.";

		public const string coErr_NoRecord = "No record found!";

		public const string coErr_RecordExists = "Record already exists!";

		public const string coErr_RecordNotExists = "Record not exists!";

		public const string coErr_RecordKeyBlank = "Blank key field!";

		public const string coRecordAdded = "Record added!";

		public const string coRecordNotAdded = "Record not added!";

		public const string coRecordUpdated = "Record edited!";

		public const string coRecordNotUpdated = "Record not edited!";

		public const string coRecordDeleted = "Record deleted!";

		public const string coRecordNotDeleted = "Record not deleted!";

		public const string coRecordNotFound = "Record not found.";

		public const string coRecordSave = "Record saved!";

		public const string coRecordUpdate = "Record updated!";

		public const string coRecordConfirm = "Record confirmed!";

		public const string coQuestionDelete = "Are you sure want to delete this record?";

		public const string coErrDocNo = "Document No cannot blank! Please check document number control.";

		public const string coErrDocNoBlank = "Document No cannot blank!";

		public const string coErr_ReportPrint = "Report printed!";

		public const string coErr_ReportNotPrint = "Report not printed!";

		public const string coErr_InvalidDate = "Invalid date entered!";

		public const string coErr_InvalidPeriod = "Invalid period entered!";

		public const string coErr_InvalidCompany = "Invalid company code entered!";

		public const string coErr_InvalidCustomer = "Invalid customer code entered!";

		public const string coErr_InvalidRegNo = "Invalid registration no entered!";

		public const string coErr_InvalidItem = "Invalid item code entered!";

		public const string coErr_InvalidCategory = "Invalid item category code entered!";

		public const string coErr_InvalidLocation = "Invalid location code entered!";

		public const string coErr_InvalidSupplier = "Invalid supplier code entered!";

		public const string coErr_InvalidUOM = "Invalid unit of measurement entered!";

		public const string coErr_InvalidBank = "Invalid bank code entered!";

		public const string coErr_InvalidBrand = "Invalid brand code entered!";

		public const string coErr_InvalidDepartment = "Invalid department code entered!";

		public const string coErr_InvalidGroup = "Invalid group code entered!";

		public const string coErr_InvalidArticle = "Invalid article code entered!";

		public const string coErr_InvalidMaker = "Invalid maker code entered!";

		public const string coErr_InvalidCarModel = "Invalid car model entered!";

		public const string coErr_InvalidCapacity = "Invalid capacity entered!";

		public const string coErr_InvalidCodeType = "Invalid code type entered!";

		public const string coErr_InvalidCode = "Invalid code entered!";

		public const string coErr_InvalidService = "Invalid service code entered!";

		public const string coErr_InvalidPackage = "Invalid package code entered!";

		public const string coErr_InvalidPIC = "Invalid person in charge entered!";

		public const string coErr_InvalidDocumentNo = "Invalid document no entered!";

		public const string coErr_InvalidInvoiceNo = "Invalid invoice no entered!";

		public const string coErr_InvalidJobNo = "Invalid job no entered!";

		public const string coErr_InvalidCMONTH = "Invalid current month entered!";

		public const string coErr_MonthClosed = "This month has been closed!";

		public const string coErr_InvalidPO = "Invalid PO entered!";

		public const string coErr_InvalidSize = "Invalid size code entered!";

		public const string coErr_InvalidColor = "Invalid color code entered!";

		public const string coErr_InvalidTableNo = "Invalid table code entered!";

		public const string coErr_InvalidWaiter = "Invalid waiter/waitress code entered!";

		public const string coErr_SystemLock = "System locked as at this date! Input not allowed.";

		public const string coErr_ConfirmPwd = "Invalid new password. Please confirm!";
	}
}
