using System;

namespace Homework_06_Exercise01
{
    public class PhotoAlbum
    {
        public PhotoAlbum()
        {
            NumberOfPages = 16;
        }
        public PhotoAlbum(int numberOfPages)
        {
            NumberOfPages = numberOfPages;
        }

        private int NumberOfPages;
        public int GetNumberOfPages()
        {
            return NumberOfPages;
        }
    }

    public class BigPhotoAlbum
    {
        public int NumberOfPages;
        public BigPhotoAlbum()
        {
            NumberOfPages = 64;
        }

      
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            //Create a class "PhotoAlbum" with a private attribute "numberOfPages".
            //It should also have a public method "GetNumberOfPages", which will return the number of pages.
            //The default constructor will create an album with 16 pages.There will be an additional constructor, with which we can specify the number of pages we want in the album.
            //Create a class "BigPhotoAlbum" whose constructor will create an album with 64 pages.
            //In main method create a "PhotoAlbum" instance with its default constructor and one with 24 pages.Also create "BigPhotoAlbum" and show the number of pages that the three albums have.

            PhotoAlbum firstAlbum = new PhotoAlbum();
            Console.WriteLine($"First album have default number of pages which is: {firstAlbum.GetNumberOfPages()}");

            PhotoAlbum secondAlbum = new PhotoAlbum(24);
            Console.WriteLine($"Second album have {secondAlbum.GetNumberOfPages()} number of pages");

            BigPhotoAlbum bigPhotoAlbum = new BigPhotoAlbum();
            Console.WriteLine($"The big album have default number of pages which is: {bigPhotoAlbum.NumberOfPages}");

        
            Console.WriteLine($"The three albums have {firstAlbum.GetNumberOfPages() + secondAlbum.GetNumberOfPages() + bigPhotoAlbum.NumberOfPages} total pages");

            Console.ReadLine();
        }
    }
}
