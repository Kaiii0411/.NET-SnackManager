using SnackManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackManager.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }
        private BillInfoDAO() { }
        public void DeleteBillInfoByFoodID(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE dbo.BillInfo WHERE idFood = " + id);
        }
        public void DeleteBillInfobyCaterogyID(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE dbo.BillInfo WHERE idFood IN ( select Food.id FROM Food WHERE Food.idCategory = " + id + " )" );
        }
        public void DeleteBillInfoByBillID(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE dbo.BillInfo WHERE idBill IN ( select Bill.id FROM Bill WHERE Bill.idTable = " + id + " )");
        }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BillInfo WHERE idBiLL = " + id);
            foreach(DataRow item  in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }
        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }
    }
}
