using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
   public class PersonViewModel
    {
        #region [- ctor -]
        public PersonViewModel()
        {
            Ref_PersonCrud = new Model.POCO.PersonCrud();
        }
        #endregion

        #region [- props -]
        public Model.POCO.PersonCrud Ref_PersonCrud { get; set; }
        #endregion

        #region [- FillGrid() -]
        public dynamic FillGrid()
        {
            return Ref_PersonCrud.SelectAll();
        }
        #endregion

        #region [- Save(string title,string phoneNumber,string mobile) -]
        public void Save(string title, string phoneNumber, string mobile)
        {
            Ref_PersonCrud.Insert(title, phoneNumber, mobile);
        }
        #endregion

        #region [- Delete -]
        public void Delete(int id)
        {
            Ref_PersonCrud.Delete(id);
        }
        #endregion

        #region [- Edit(int id, string title, string phoneNumber, string mobile) -] 
        public void Edit(int id, string title, string phoneNumber, string mobile)
        {
            Ref_PersonCrud.Edit(id, title, phoneNumber, mobile);
        }
        #endregion
    }
}
