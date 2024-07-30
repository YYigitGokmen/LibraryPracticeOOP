using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PatikaLibraryPractice
{
    internal class bookRecord
    {
        //bookRecord sınıfı ile bir kütüphane kayıt sistemi oluşturdum
        //Sınıflar bir taslak gibidir içlerine alabilecekleri
        //değerler metotlar ve constructorlar ile OOP de bizim yapıları oluşturmamızı sağlarlar

        private string? _name;
        private string? _writerName;
        private string? _writerSurName;
        private int _pageSize;
        private string? _publisher;
        private int _dateOfRegistration;

        public string Name
        {

            get { return _name; }

            set
            {
                _name = value;
            }

        }

        public string WriterName
        {

            get { return _writerName; }

            set
            {
                _writerName = value;
            }

        }

        public string WriterSurName
        {

            get { return _writerSurName; }

            set
            {
                _writerSurName = value;
            }

        }
        public int PageSize
        {

            get
            {
                return _pageSize;
            }
            set
            {
                if (value >= 0)

                { _pageSize = value; }

            }
        }

        public string Publisher
        {

            get { return _publisher; }

            set
            {
                _publisher = value;
            }

        }
        public int DateOfRegistration
        {

            get
            {
                return _dateOfRegistration;
            }
            set
            {
                if (value >= 0)

                { _dateOfRegistration = value; }

            }
        }

        public DateTime CreatedDateTime { get; private set; }

        //Propertiler ise oop nin 4 temel yapı taşından biri olan Encapsulationu
        //kullanabilmemizi sağlar bilgilerin nasıl okunabileceğini ve kontrol 
        //edilebileceğini ayarlarız örnek olarak sadece get varsa value okunabilir
        //sadece set varsa value değiştirilebilir





        public bookRecord()
        {

            CreatedDateTime = DateTime.Now;
            Console.WriteLine($"Kayıt Tarihi {CreatedDateTime}");
        }

        //KayıtTarihi nesne oluşturulunca otomatik olarak
        //o an olarak atansın. (Her iki constructor için de geçerli)
        public bookRecord(string name,string writername,
            string writersurname,int pagesize,string publisher)
        {
            _name=name;
            _writerName=writername;
            _writerSurName=writersurname;
            _pageSize=pagesize;
            _publisher=publisher;
            CreatedDateTime = DateTime.Now;
           ;

            Console.WriteLine($"{_name} adlı kitap  {_writerName}{_writerSurName}'e aittir ve {_pageSize} sayfadır," +
                $" {_publisher} kitapevinden çıkmıştır");
            Console.WriteLine($"Kayıt Tarihi {CreatedDateTime}");

        }










    }
    }
