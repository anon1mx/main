using System;

namespace CSharp_Net_module1_2_1_lab
{

    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser

    

    interface ILibraryUser
    {
        string AddBook();
        string RemoveBook();
        string BookInfo();
        int BooksCount();
        
    }
    
    class LibraryUser : ILibraryUser
    {

        public int Phone { get; set; }
        public readonly int BookLimit;
        public readonly Guid id;
        public readonly string FirstName;
        public readonly string LastName;
        string[] bookList = new string[] { "Sherlock Holmes", "Kobzar", "Dorian Gray", "Harry Potter" };

        public string AddBook()
        {
            return "Добвил книгу";
        }

        public string BookInfo()
        {
            return "инфа о книге";
        }

        public string RemoveBook()
        {
            return "Удалил книгу";
        }

        public int BooksCount()
        {
           return 1;
        }
       
        
        
        

    } 
    // 2) declare class LibraryUser, it implements ILibraryUser


    // 3) declare properties: FirstName (read only), LastName (read only), 
    // Id (read only), Phone (get and set), BookLimit (read only)

    // 4) declare field (bookList) as a string array


    // 5) declare indexer BookList for array bookList

    // 6) declare constructors: default and parameter

    // 7) declare methods: 

    //AddBook() – add new book to array bookList

    //RemoveBook() – remove book from array bookList

    //BookInfo() – returns book info by index

    //BooksCout() – returns current count of books
    // Цель: Получение практического опыта работы с классами, объектами, конструкторами, свойства, индексаторы, интерфейсы
    //Задача: Разработать программу, имитирующую деятельность библиотеки.
    //Объявите интерфейс ILibraryUser с помощью методов AddBook(),
    //RemoveBook(), BookInfo(), BooksCount()
    //Делайте класс LibraryUser, он реализует ILibraryUser.Участники:
    //- свойства Имя (только для чтения), Фамилия(только для чтения), Идентификатор(только для чтения), Телефон(получить
    //и установить), BookLimit(только для чтения)
    //поле bookList(закрытый строковый массив
    //- Индексатор BookList (для массива bookList);
    //- Конструкторы-дефолт и параметр;
    //- Методы AddBook()- добавить новую книгу в массив bookList, RemoveBook() удалить
    //книга из массива bookList, Booklnfo() - возвращает информацию о книге по индексу, BooksCout(0
    //возвращает текущее количество книг
    //Объявить 2 объекта: user1, user2(использовать конструктор по умолчанию, параметр
    //конструктор).
    //Выполнять все операции для каждого пользователя
}
