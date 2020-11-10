using System;

namespace Golf1
{
    class GolfCourse
    {
        public bool GameCourseStatus { get; set; }

        public void GameStart()
        {
            GameCourseStatus = true;
            GameIntro();
        }

        public void GameIntro()
        {
            Console.WriteLine("Simple Golf Console Application");
            Console.WriteLine();
        }

        // Default constructor.
        public GolfCourse() { }
    }
}
