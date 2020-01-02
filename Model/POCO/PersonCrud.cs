using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.POCO
{
   public class PersonCrud
    {
        #region [- ctor -]
        public PersonCrud()
        {

        }
        #endregion

        #region [- SelectAll() -]
        public List<Model.DTO.Person> SelectAll()
        {
            using (var context = new Model.DTO.PhonebookEntities())
            {
                try
                {
                    var q = context.Person.ToList();
                    return q;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Insert(string title, string phoneNumber,string mobile) -]
        public void Insert(string title, string phoneNumber, string mobile)
        {
            using (var context = new Model.DTO.PhonebookEntities())
            {
                try
                {
                    Model.DTO.Person ref_Person = new DTO.Person();
                    ref_Person.Title = title;
                    ref_Person.PhoneNumber = phoneNumber;
                    ref_Person.Mobile = mobile;
                    context.Person.Add(ref_Person);
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- DeleteRow -]
        public void Delete(int id)
        {
            using (var context = new Model.DTO.PhonebookEntities())
            {
                try
                {
                    var q = context.Person.First(p => p.ID == id) as Model.DTO.Person;
                    if (q != null)
                    {
                        context.Person.Remove(q);
                        context.SaveChanges();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion





        #region [- Edit(int id, string title, string phoneNumber, string mobile) -]
        public void Edit(int id, string title, string phoneNumber, string mobile)
        {
            using (var context = new Model.DTO.PhonebookEntities())
            {
                try
                {
                    var q = context.Person.First(p => p.ID == id) as Model.DTO.Person;
                    if (q != null)
                    {
                        q.Title = title;
                        q.PhoneNumber = phoneNumber;
                        q.Mobile = mobile;
                      
                        context.Entry(q).CurrentValues.SetValues(context.Person);
                        context.SaveChanges();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }

        }
        #endregion


    }
}
