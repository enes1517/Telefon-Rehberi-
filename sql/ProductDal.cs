using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql
{
    public class ProductDal
    {
        public List<product> GetAll()
        {
            using (PhoneContext context = new PhoneContext())
            {
               return context.Products.ToList();
            }
        }

        public void Add(product product)
        {
            using (PhoneContext context = new PhoneContext())
            {
                // context.Products.Add(product);
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void update(product product)
        {
            using (PhoneContext context = new PhoneContext())
            {
                var entity=context.Entry(product);
                entity.State=EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void delete(product product)
        {
            using (PhoneContext context = new PhoneContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
       
          
        




    }
}
