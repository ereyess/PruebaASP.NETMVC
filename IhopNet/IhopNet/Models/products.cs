namespace IhopNet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    public partial class products
    {

        [Key]
        public short Product_ID { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Unity { get; set; }

        public short? Category_ID { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("Categories")]
        [UIHint("List")]

        public List<SelectListItem> CategoriesLista { get; set; }

        public int Cid { get; set; }

        public products()
        {
            DataCategoriesDataContext data = new DataCategoriesDataContext();
            CategoriesLista = new List<SelectListItem>();

            var query = from C in data.Categories select C;
            var listData = query.ToList();
            foreach (var Datos in listData)
            {
                CategoriesLista.Add(new SelectListItem()
                {
                    Value = Datos.Category_ID.ToString(),
                    Text = Datos.Description
                });
            }
        }

    }
}
