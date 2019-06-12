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
            int delayDays = DateTime.Now.Year - DateWhenPicked.Year;
            if (delayDays > DaysTillReturn)
            {
                return true;
            }
            else
            {
                return false;
            }
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
