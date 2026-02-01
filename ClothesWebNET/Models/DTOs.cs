using System;

namespace ClothesWebNET.Models
{
    // DTO cho thông tin user đăng nhập
    public class UserLogin
    {
        public string idUser { get; set; }
        public string UserName { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
    }

    // DTO cho hiển thị danh sách hóa đơn
    public class BillData
    {
        public string idBill { get; set; }
        public string idUser { get; set; }
        public int Ship { get; set; }
        public int Total { get; set; }
        public string PTTT { get; set; }
        public bool status { get; set; }
        public DateTime createdAt { get; set; }
        public int Qty { get; set; }
        public string nameUser { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }

    // DTO cho chi tiết hóa đơn
    public class ItemDetail
    {
        public string nameBook { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string idBill { get; set; }
        public int Total { get; set; }
        public string idDetailBill { get; set; }
        public string nameProduct { get; set; }
        public string idProduct { get; set; }
        public int qty { get; set; }
        public double price { get; set; }
        public int intoMoney { get; set; }
    }

    // DTO cho chi tiết sản phẩm
    public class ProductDTODetail
    {
        public string idProduct { get; set; }
        public string nameProduct { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public string idType { get; set; }
        public int qty { get; set; }
        public string type { get; set; }
        public string URLImage { get; set; }
        public int sizeL { get; set; }
        public int sizeM { get; set; }
        public int sizeXL { get; set; }
    }
}
