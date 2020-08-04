using System;
using Sessao9_Exercicio2.Entities;
using System.Collections.Generic;

namespace Sessao9_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            int Count = 0;

            Console.WriteLine("\n\n   Éoq of posts programm ");

            Console.Write("\n   Enter the Post date: ");
            DateTime FDate = DateTime.Parse(Console.ReadLine());

            Console.Write("\n   Enter the Post title: ");
            string FTitle = Console.ReadLine();

            Console.Write("\n   Enter the Post content: ");
            string FContent = Console.ReadLine();

            Console.Write("\n   How many likes does the post have at the start? ");
            int FLikes = int.Parse(Console.ReadLine());

            List<Post> FPostList = new List<Post>(); // instancing list of objects of Post Class
            FPostList.Add(new Post() { Date = FDate, Title = FTitle, Content = FContent, Likes = FLikes });
            foreach (Post obj in FPostList) // Discovering the FPostList Post index position per added post
            {
                Count += 1;
            }

            Console.Write("\n   How many comments do you want to add in this post? ");
            int n = int.Parse(Console.ReadLine());

            Comment NowComment = new Comment("Testando a classe Comment"); // Creating a separeted Comment obj called NowComment
            List<string> FComments = new List<string>();
            Console.WriteLine("\n");

            for (int i = 1; i <= n; i++)
            {
                Console.Write("   Type the comment: ");
                string ThatComment = Console.ReadLine();
                FComments.Add(ThatComment);
                NowComment = new Comment(ThatComment); // test
                Console.WriteLine("   The writen Comment in the Comment class NowComment obj, calling NowComment.Text in this for is: " + NowComment.Text); // calling the Comment obj NowComment Text attribute              
            }
            Console.WriteLine();

            foreach (string obj in FComments)
            {
                FPostList[Count - 1].PostComment.Add(new Comment(obj));
                Console.WriteLine("\n   Comment in FPostList[0].PostComment, which is a list of Comment in the FPostList(list of Posts), calling FPostList[0].PostComment(list of Comments).Add: ");
                Console.Write("   " + FPostList[Count - 1].PostComment[id]);
                id++;
            }
            Console.WriteLine();

            foreach (Comment obj in FPostList[Count - 1].PostComment)
            {
                Console.Write("\n   The writen comment in the FPostList[0].PostComment List calling foreach Comment obj is: \n   " + obj);
            }

            Console.WriteLine("\n\n\n   The Post info will be showed bellow: ");
            Console.WriteLine();
            Console.Write(FPostList[Count - 1]);
            foreach (Comment obj in FPostList[Count - 1].PostComment)
            {
                Console.Write("\n   " + obj);
            }
            Console.WriteLine();

            // Loop function to add new posts BELOW     

            Console.Write("\n   Do you want to add a new post? Y/N? ");
            char Answer2 = char.Parse(Console.ReadLine());

            while (Answer2 != 'Y' && Answer2 != 'N' && Answer2 != 'y' && Answer2 != 'n')
            {
                Console.WriteLine("\n   You've entered a wrong answer, please try again!");
                Console.Write("   Do you want to add a new post? Y/N? ");
                Answer2 = char.Parse(Console.ReadLine());
            }
            if (Answer2 == 'Y' || Answer2 == 'y') // BIG IF
            {
                Operations(FPostList);
            }
            else if (Answer2 == 'N' || Answer2 == 'n') // BIG IF
            {
                Console.WriteLine("\n\n   The end ");
            }

            static void Operations(List<Post> thatList)
            {                
                int Count = 0;
                int id2 = 0;
                int id3 = 0;

                Console.Write("\n   Enter the Post date: ");
                DateTime FDate2 = DateTime.Parse(Console.ReadLine()); // I could have used FDate without '2' because 
                                                                      // here is another scope
                Console.Write("\n   Enter the Post title: ");
                string FTitle2 = Console.ReadLine();

                Console.Write("\n   Enter the Post content: ");
                string FContent2 = Console.ReadLine();

                Console.Write("\n   How many likes does the post have at the start? ");
                int FLikes2 = int.Parse(Console.ReadLine());

                Console.Write("\n   How many comments do you want to add in this post? ");
                int n2 = int.Parse(Console.ReadLine());

                thatList.Add(new Post() { Date = FDate2, Title = FTitle2, Content = FContent2, Likes = FLikes2 });
                foreach (Post obj in thatList) // Discovering the FPostList Post index position per added post
                {
                    Count += 1;
                }
                Console.WriteLine($"\n   Count value is {Count} now");

                List<string> FComments2 = new List<string>();
                Console.WriteLine("\n");

                for (int i = 1; i <= n2; i++)
                {
                    Console.Write("   Type the comment: ");
                    string ThatComment = Console.ReadLine();
                    FComments2.Add(ThatComment);
                }
                Console.WriteLine();

                foreach (string obj in FComments2)
                {
                    thatList[Count - 1].PostComment.Add(new Comment(obj));
                    Console.WriteLine("\n   Comment in FPostList[0].PostComment, which is a list of Comment in the FPostList(list of Posts), calling FPostList[0].PostComment(list of Comments).Add: ");
                    Console.Write("   " + thatList[Count - 1].PostComment[id2]);
                    id2++;
                }
                Console.WriteLine();

                foreach (Comment obj in thatList[Count - 1].PostComment)
                {
                    Console.Write("\n   The writen comment in the FPostList[0].PostComment List calling foreach Comment obj is: \n   " + obj);
                }

                Console.WriteLine("\n\n\n   The Posts info will be showed bellow: ");
                Console.WriteLine();
                foreach (Post obj in thatList)
                {
                    Console.Write(obj);
                    id3++;
                    foreach (Comment objct in thatList[id3 - 1].PostComment)
                    {
                        Console.Write("\n   " + objct);
                    }
                    Console.WriteLine("\n");
                }

                // Asking again for adding a new post or not

                Console.Write("\n   Do you want to add a new post? Y/N? ");
                char Answer1 = char.Parse(Console.ReadLine());

                while (Answer1 != 'Y' && Answer1 != 'N' && Answer1 != 'y' && Answer1 != 'n')
                {
                    Console.WriteLine("\n   You've entered a wrong answer, please try again!");
                    Console.Write("   Do you want to add a new post? Y/N? ");
                    Answer1 = char.Parse(Console.ReadLine());
                }
                if (Answer1 == 'Y' || Answer1 == 'y') // BIG IF
                {
                    Operations(thatList); // This if will ALWAYS call Operations again to ever adding a New Post
                }
                else if (Answer1 == 'N' || Answer1 == 'n') // BIG IF
                {
                    Console.WriteLine("\n\n   The end ");
                }
            }
        }
    }
}