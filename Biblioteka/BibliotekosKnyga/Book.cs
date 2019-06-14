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
            if (DateTime.Now.Year - DateWhenPicked.Year > DaysTillReturn)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public decimal Cost()
        {
            return ((DateTime.Now.Year - DateWhenPicked.Year) * 1);
        }
        public Book(int id, string bookName, int daysTillReturn, string userName, DateTime dateWhenPicked)
        {
            ID = id;
            BookName = bookName;
            DaysTillReturn = daysTillReturn;
            UserName = userName;
            DateWhenPicked = dateWhenPicked;
        }
    }
}
