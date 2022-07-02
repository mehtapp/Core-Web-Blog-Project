using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    //Business katmanında abstrack klasörü içinde yer alan iterfaceler servis olaran adlandırılır.
    //Business katmanında concrete klasörü içinde yer alan  sınıflar manager olarak adlandırılır.
    public class CategoryManager : ICategoryService  //validaton Rules yapıcaz
    {
        readonly EfCategoryRepository _efCategoryRepository;
        public CategoryManager() //yapıcı metot içinde newleme işlemi gerçekleştirdik
        {
            _efCategoryRepository = new EfCategoryRepository();

        }
        //readonly GenericRepository<Category> repo=new GenericRepository<Category>(); bu yerine efli olan burda
        // tum generiği çağırmış oluyormus
        public void CategoryAdd(Category category)
        {
           _efCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _efCategoryRepository.Delete(category);
        }
        public void CategoryUpdate(Category category)
        {
            _efCategoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
            return _efCategoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return _efCategoryRepository.GetListAll();
        }
    }
}
