using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dao
{
    public class UserDao
    {
        CafeDbContext db = null;
        public UserDao()
        {
            db = new CafeDbContext();//Khởi tạo db
        }

        public string Insert(TaiKhoan entity) //Thêm mới user
        {
            db.TaiKhoans.Add(entity);
            db.SaveChanges();
            return entity.MaTK;
        }
       
        public TaiKhoan GetbyID(string userName)
        {
            return db.TaiKhoans.SingleOrDefault(x => x.UsernameTK == userName);
        }
        public bool Login(string userName, string passWord)
        {
            var result = db.TaiKhoans.Count(x => x.UsernameTK == userName && x.PasswordTK == passWord);
            if (result > 0)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

