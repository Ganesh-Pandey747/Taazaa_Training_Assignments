using Assignment_10.Models;
using System.Collections.Generic;
namespace Assignment_10.ListManipulation
{
    public interface IListMainpulator
    {
         void createList(Contact objContact);
        void updateList();
        void deleteList();
        List<Contact> DisplayList();

    }
}