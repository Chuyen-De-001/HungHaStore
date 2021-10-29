namespace hung_ha.Models.DbSet
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblInfo")]
    public partial class tblInfo
    {

        public int id { get; set; }

        [StringLength(255)]
        [DisplayName("Họ và tên")]
        public string name { get; set; }

        [DisplayName("Mã tài khoản")]
        public int? user_id { get; set; }

        [StringLength(50)]
        [DisplayName("Giới tính")]
        public string sex { get; set; }

        [StringLength(50)]
        [DisplayName("Số điện thoại")]
        public string phone_number { get; set; }

        [StringLength(255)]
        [DisplayName("Địa chỉ")]
        public string address { get; set; }

        [StringLength(255)]
        [DisplayName("Ngày sinh")]
        public string date_of_bith { get; set; }

        [StringLength(255)]
        [DisplayName("Thời gian tạo")]
        public string created_at { get; set; }

        public virtual tblUser tblUser { get; set; }
    }
}
