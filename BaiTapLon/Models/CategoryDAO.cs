using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapLon.Models
{
    public class CategoryDAO
    {

        Data db = null;
        public CategoryDAO()
        {
            db = new Data();
        }
        public List<tblCategory> ListCategory()
        {
            return db.tblCategories.ToList();
        }

        //Lấy ra tên của 1 category
        public tblCategory ListCategoryByCatId(int catid)
        {
            return db.tblCategories.Find(catid); //para phải là pmkey trong bảng
        }
    }
}