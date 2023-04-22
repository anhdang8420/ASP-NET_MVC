using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapLon.Models
{
    public class ProductDAO
    {
        Data db = null;
        public ProductDAO()
        {
            db = new Data();
        }
        public List<tblProduct> ListProductsByCate(int cat)
        {
            var list = db.tblProducts.Where(p => p.Categoryid == cat);
            return list.ToList();
        }
    }
}