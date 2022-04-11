using BookWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWeb.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<Category>
    {
        void Update(CoverType obj);
     
   
    }
}
