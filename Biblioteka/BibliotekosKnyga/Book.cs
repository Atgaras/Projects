using System;

namespace BibliotekosKnyga
{
    public class Book
    {
        public int ID { get; private set; }
        public string BookName { get; private set; }
        public int DaysTillReturn { get; private set; }
        public string UserName { get; set; }
        public DateTime DateWhenPicked { get; set; }
        public bool IsDelay()
        {
            
        }
        public Book(int id, string bookName, int daysTillReturn, string userName, DateTime dateWhenPicked, bool )
        {
            ID = id;
            BookName = bookName;
            DaysTillReturn = daysTillReturn;
            UserName = userName;
            DateWhenPicked = dateWhenPicked;
        }
    }
}
