using System;

namespace Triangle_Battleship_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            bool gameContinue = true;               // Will be used for game loop
            bool doesFormTriangle = true;           // Will be used for triangle validation
            bool isShipDefined = false;             // Will be used for option selection
            bool isPointValid = true;               // Will be used for point validation

            string Ax = " ";
            string Ay = " ";
            string Bx = " ";                        // Coordinates of triangle's corners
            string By = " ";
            string Cx = " ";
            string Cy = " ";

            string scoreboardFirstName = "Nazan Kaya";
            string scoreboardSecondName = "Ali Kurt";       // Scoreboard names, will be used for scoreboard
            string scoreboardThirdName = "Elif Polat";

            double scoreboardFirstPoint = 60;
            double scoreboardSecondPoint = 30;              // Scoreboard points, will be used for scoreboard
            double scoreboardThirdPoint = 24;

            double shipArea = 0;                            // Ship area, will be used for scoreboard and shooting mechanic

            double bulletAB = 0;
            double bulletAC = 0;                            // Areas of three corners of triangle and bullet. Will be used for shooting.
            double bulletBC = 0;

            double bulletTrianglesArea = 0;             // Sum of the areas above

            double lengthA = 0;
            double lengthB = 0;                         // Side lengths of the triangle
            double lengthC = 0;

            int userOption = 0;                           // User input for menu

            Random rnd = new Random();                  // Will be used for creating bullet


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("           ------ HOW TO PLAY ------");
            Console.WriteLine("Game is played on a 30x12 coordinate plane.");
            Console.WriteLine("Define your ship by choosing option 1 from the menu.");
            Console.WriteLine("If you choose option 2 or option 3 without defining the ship, you will get an error. ");
            Console.WriteLine("After defining the ship if you choose option 2 from the menu, you can see the properties of the ship. ");
            Console.WriteLine("If you choose option 3 from the menu after defining the ship, the computer will randomly shoot a bullet.");      // How to play section
            Console.WriteLine("If the ship survives, user earns points equal to the area of the ship.");
            Console.WriteLine("If the ship can't survive, user can't earn point.");
            Console.WriteLine("To see the high score table, you can choose option 4 from the menu.");
            Console.WriteLine("You can exit the game by choosing option 5 from the menu.");
            Console.WriteLine("The aim of the game is achieving highest score and defeat other players.");
            Console.WriteLine();
            Console.WriteLine();



            while (gameContinue)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;



                Console.WriteLine("-MENU-");
                Console.WriteLine("1-Enter Ship Location");
                Console.WriteLine("2-Ship Info");
                Console.WriteLine("3-Shoot at the ship");                   // Printing menu
                Console.WriteLine("4-Show High Score Table");
                Console.WriteLine("5-Exit");

                Console.Write("Please choose option from the menu: ");

                Console.ResetColor();


                try
                {
                    userOption = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (userOption < 1 || userOption > 5)
                    {

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("WARNING: You should enter a integer between 1-5");           // Storing user input, throwing error when input is invalid
                        Console.ResetColor();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("WARNING: You should enter a integer between 1-5");
                    Console.ResetColor();
                }





                if (userOption == 1)
                {
                    doesFormTriangle = false;
                    isShipDefined = false;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Please enter the location of the ship");

                    while (!doesFormTriangle)       // while loop for checking triangle is valid.
                    {


                        while (isPointValid)                                                    // While loop for checking point is valid. User can't break the loop without defining valid point
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("Ax: ");
                            Ax = Console.ReadLine();
                            try
                            {
                                Convert.ToInt16(Ax);
                                if (Convert.ToInt16(Ax) < 1 || Convert.ToInt16(Ax) > 30)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;                                 // Storing coordinates, throwing error when input is invalid
                                    Console.WriteLine("WARNING: You should enter a integer between 0-30");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    isPointValid = false;
                                }
                            }
                            catch (Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("WARNING: You should enter a integer between 0-30");              // Storing coordinates, throwing error when input is invalid
                                Console.ResetColor();
                            }
                        }

                        isPointValid = true;

                        while (isPointValid)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("Ay: ");
                            Ay = Console.ReadLine();
                            try
                            {
                                Convert.ToInt16(Ax);
                                if (Convert.ToInt16(Ay) < 1 || Convert.ToInt16(Ay) > 12)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("WARNING: You should enter a integer between 0-12");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                }
                                else
                                {
                                    isPointValid = false;
                                }
                            }
                            catch (Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("WARNING: You should enter a integer between 0-12");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                            }
                        }

                        isPointValid = true;

                        while (isPointValid)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("Bx: ");
                            Bx = Console.ReadLine();
                            try
                            {
                                Convert.ToInt16(Bx);
                                if (Convert.ToInt16(Bx) < 1 || Convert.ToInt16(Bx) > 30)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("WARNING: You should enter a integer between 0-30");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                }
                                else
                                {
                                    isPointValid = false;
                                }
                            }
                            catch (Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("WARNING: You should enter a integer between 0-30");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                            }
                        }

                        isPointValid = true;

                        while (isPointValid)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("By: ");
                            By = Console.ReadLine();
                            try
                            {
                                Convert.ToInt16(By);
                                if (Convert.ToInt16(By) < 1 || Convert.ToInt16(By) > 12)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("WARNING: You should enter a integer between 0-12");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                }
                                else
                                {
                                    isPointValid = false;
                                }
                            }
                            catch (Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("WARNING: You should enter a integer between 0-12");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                            }
                        }

                        isPointValid = true;

                        while (isPointValid)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("Cx: ");
                            Cx = Console.ReadLine();
                            try
                            {
                                Convert.ToInt16(Cx);
                                if (Convert.ToInt16(Cx) < 1 || Convert.ToInt16(Cx) > 30)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("WARNING: You should enter a integer between 0-30");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                }
                                else
                                {
                                    isPointValid = false;
                                }
                            }
                            catch (Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("WARNING: You should enter a integer between 0-30");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                            }
                        }

                        isPointValid = true;

                        while (isPointValid)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("Cy: ");
                            Cy = Console.ReadLine();
                            try
                            {
                                Convert.ToInt16(Cx);
                                if (Convert.ToInt16(Cy) < 1 || Convert.ToInt16(Cy) > 12)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("WARNING: You should enter a integer between 0-12");

                                }
                                else
                                {
                                    isPointValid = false;
                                }
                            }
                            catch (Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("WARNING: You should enter a integer between 0-12");

                            }
                        }

                        isPointValid = true;
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.WriteLine("A: (" + Ax + "," + Ay + ")");
                        Console.WriteLine("B: (" + Bx + "," + By + ")");                // Printing coordinates of triangle
                        Console.WriteLine("C: (" + Cx + "," + Cy + ")");
                        Console.WriteLine();


                        shipArea = Math.Abs(Convert.ToDouble(Ax) * (Convert.ToDouble(By) - Convert.ToDouble(Cy)) + Convert.ToDouble(Bx) * (Convert.ToDouble(Cy) - Convert.ToDouble(Ay))
                                + Convert.ToDouble(Cx) * (Convert.ToDouble(Ay) - Convert.ToDouble(By))) / 2.0;     // Calculating ship area


                        lengthA = Math.Sqrt(Math.Pow(Convert.ToDouble(Cx) - Convert.ToDouble(Bx), 2.0) +
                                            Math.Pow(Convert.ToDouble(Cy) - Convert.ToDouble(By), 2.0));
                        lengthB = Math.Sqrt(Math.Pow(Convert.ToDouble(Ax) - Convert.ToDouble(Cx), 2.0) +        // Calculating lengths of sides
                                            Math.Pow(Convert.ToDouble(Ay) - Convert.ToDouble(Cy), 2.0));
                        lengthC = Math.Sqrt(Math.Pow(Convert.ToDouble(Ax) - Convert.ToDouble(Bx), 2.0) +
                                            Math.Pow(Convert.ToDouble(Ay) - Convert.ToDouble(By), 2.0));

                        for (int i = 12; i >= 0; i--)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            if (i < 10)
                            {
                                Console.Write(" " + Convert.ToString(i));
                            }

                            else
                            {
                                Console.Write(i);
                            }

                            for (int j = 0; j <= 30; j++)
                            {

                                if (i == Convert.ToInt32(Ay) && j == Convert.ToInt32(Ax))
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write("A");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }

                                else if (i == Convert.ToInt32(By) && j == Convert.ToInt32(Bx))
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write("B");                                                         // Drawing the ship on the coordinate plane
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }

                                else if (i == Convert.ToInt32(Cy) && j == Convert.ToInt32(Cx))
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write("C");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }

                                else if (i == 0 && j == 0)
                                {
                                    Console.Write("+");
                                }
                                else if (j == 0)
                                {
                                    Console.Write("|");
                                }
                                else if (i == 0)
                                {
                                    Console.Write("-");

                                }
                                else
                                {

                                    Console.Write(" ");
                                }


                            }


                            Console.WriteLine();
                        }

                        Console.WriteLine("   123456789012345678901234567890");


                        Console.WriteLine();
                        Console.ResetColor();

                        if (lengthA + lengthB > lengthC && lengthB + lengthC > lengthA && lengthA + lengthC > lengthB)      // Triangle validation
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Ship has been created successfully! ");
                            isShipDefined = true;
                            doesFormTriangle = true;

                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(
                                "These three points do not form a triangle. Please re-enter three points.");            // Throwing error when triangle is invalid
                            Console.WriteLine();
                        }

                    }


                    Console.WriteLine();

                }


                if (userOption == 2)
                {
                    if (isShipDefined)                                  // Checking if the ship defined
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        double pi = Math.PI;

                        double ax = Convert.ToDouble(Ax);
                        double ay = Convert.ToDouble(Ay);
                        double bx = Convert.ToDouble(Bx);               // Converting Strings to Double
                        double by = Convert.ToDouble(By);
                        double cx = Convert.ToDouble(Cx);
                        double cy = Convert.ToDouble(Cy);




                        Console.WriteLine("A:  (" + ax + "," + ay + ")");
                        Console.WriteLine("B:  (" + bx + "," + by + ")");       // Printing coordinates
                        Console.WriteLine("C:  (" + cx + "," + cy + ")");

                        Console.WriteLine();


                        double perimeter = lengthA + lengthB + lengthC;     // Calculating Perimeter

                        double areaAbsolute = Math.Round(Math.Abs(shipArea), 2);                                    // Calculating Area

                        double aMedianX = Math.Round((bx + cx) / 2, 2);
                        double aMedianY = Math.Round((by + cy) / 2, 2);
                        double bMedianX = Math.Round((ax + cx) / 2, 2);     // Calculating median points
                        double bMedianY = Math.Round((ay + cy) / 2, 2);
                        double cMedianX = Math.Round((ax + bx) / 2, 2);
                        double cMedianY = Math.Round((ay + by) / 2, 2);

                        double xg = Math.Round((ax + bx + cx) / 3, 2);
                        double yg = Math.Round((ay + by + cy) / 3, 2);      // Calculating centroid of the ship


                        double areau = ((lengthA + lengthB + lengthC) / 2);  // Calculating u


                        double bisector = (1 - ((lengthA * lengthA) / (lengthB * lengthB + lengthC * lengthC + 2 * lengthB * lengthC))) * (lengthB * lengthC);
                        double bisectork = Math.Round(Math.Sqrt(bisector), 2);   // Calculating bisector


                        double inscribed = Math.Round(pi * (areaAbsolute / areau) * (areaAbsolute / areau), 2);      // Calculating inscribed circle

                        double circumscribed = Math.Round(pi * ((lengthA * lengthB * lengthC) / (areaAbsolute * 4)) *   // Calculating circumscribed circle
                                                          ((lengthA * lengthB * lengthC) / (areaAbsolute * 4)), 2);


                        double cosA = (lengthB * lengthB + lengthC * lengthC - lengthA * lengthA) / (2 * lengthB * lengthC);
                        double cosB = (lengthA * lengthA + lengthC * lengthC - lengthB * lengthB) / (2 * lengthA * lengthC);
                        double cosC = (lengthA * lengthA + lengthB * lengthB - lengthC * lengthC) / (2 * lengthA * lengthB);

                        double arccosA = Math.Acos(cosA);
                        double arccosB = Math.Acos(cosB);                               // Calculating angles
                        double arccosC = Math.Acos(cosC);

                        double aAngle = Math.Round(180 * arccosA / pi, 4);
                        double bAngle = Math.Round(180 * arccosB / pi, 4);
                        double cAngle = Math.Round(180 * arccosC / pi, 4);


                        Console.Write("The size of the ship: a=" + Math.Round(lengthA, 2));
                        Console.Write(", b=" + Math.Round(lengthB, 2));
                        Console.Write(", c=" + Math.Round(lengthC, 2));
                        Console.WriteLine(" ");
                        Console.WriteLine("The perimeter of the ship: " + Math.Round(perimeter, 2));
                        Console.WriteLine("The area of the ship: " + areaAbsolute);
                        Console.WriteLine("The angles of the ship: A=" + Math.Round(aAngle, 2) +                    // Printing ship properties
                                          "  B=" + Math.Round(bAngle, 2) + "  C=" + Math.Round(cAngle, 2));
                        Console.Write("The median points:  (" + aMedianX + "," + aMedianY + ")");
                        Console.Write("  (" + bMedianX + "," + bMedianY + ")");
                        Console.WriteLine("  (" + cMedianX + "," + cMedianY + ")");
                        Console.WriteLine("The centroid of the ship:  (" + xg + "," + yg + ")");
                        Console.WriteLine("The length of the bisector: " + bisectork);
                        Console.WriteLine("The area of the inscribed circle: " + inscribed);
                        Console.WriteLine("The area of circumscribed circle: " + circumscribed);


                        if ((lengthA == lengthB || lengthB == lengthC || lengthA == lengthC) && (aAngle >= 91 || bAngle >= 91 || cAngle >= 91))
                        {

                            Console.WriteLine("The type of the ship: Isosceles (Obtuse-angled) ");
                        }
                        else if ((lengthA == lengthB || lengthB == lengthC || lengthA == lengthC) && (aAngle == 90))
                        {

                            Console.WriteLine("The type of the ship: Isosceles (Right-angled) ");
                        }
                        else if ((lengthA == lengthB || lengthB == lengthC || lengthA == lengthC) && (bAngle == 90))
                        {
                            Console.WriteLine("The type of the ship: Isosceles (Right-angled) ");

                        }
                        else if ((lengthA == lengthB || lengthB == lengthC || lengthA == lengthC) && (cAngle == 90))    // Calculating and printing type of ship
                        {
                            Console.WriteLine("The type of the ship: Isosceles (Right-angled) ");

                        }
                        else if ((lengthA == lengthB || lengthB == lengthC || lengthA == lengthC) && (aAngle <= 89 && bAngle <= 89 && cAngle <= 89))
                        {

                            Console.WriteLine("The type of the ship: Isosceles (Acute-angled) ");

                        }

                        else if ((lengthA != lengthB && lengthA != lengthC && lengthB != lengthC) && (aAngle >= 91 || bAngle >= 91 || cAngle >= 91))
                        {

                            Console.WriteLine("The type of the ship: Scalane (Obtuse-angled) ");

                        }

                        else if ((lengthA != lengthB && lengthA != lengthC && lengthB != lengthC) && (aAngle == 90 || bAngle == 90 || cAngle == 90))
                        {

                            Console.WriteLine("The type of the ship: Scalene (Right-angled) ");

                        }


                        else if ((lengthA != lengthB && lengthA != lengthC && lengthB != lengthC) && (aAngle <= 89 && bAngle <= 89 && cAngle <= 89))
                        {

                            Console.WriteLine("The type of the ship: Scalane (Acute-angled) ");
                        }

                        else if ((lengthB == lengthC) && (aAngle == 90))
                        {

                            Console.WriteLine("The type of the ship: Isosceles (Right-angled) ");
                        }

                        else if (lengthA == lengthB && lengthB == lengthC && lengthA == lengthC)

                        {
                            Console.WriteLine("The type of the ship:  Equilateral  (Acute-angled) ");
                        }
                        Console.WriteLine();

                        Console.ResetColor();
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("You have to define a ship first!");
                        Console.WriteLine();                                        // Throwing error when the ship is not defined
                        Console.ResetColor();
                    }

                }

                if (userOption == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    if (isShipDefined)
                    {
                        int bulletX = rnd.Next(1, 30);
                        int bulletY = rnd.Next(1, 12);               // Creating bullet

                        Console.WriteLine("Bullet: " + "(" + bulletX + "," + bulletY + ")");      // Printing bullet

                        for (int i = 12; i >= 0; i--)
                        {
                            if (i < 10)
                            {
                                Console.Write(" " + Convert.ToString(i));
                            }

                            else
                            {
                                Console.Write(i);
                            }

                            for (int j = 0; j <= 30; j++)
                            {
                                if (i == bulletY && j == bulletX)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("x");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }

                                else if (i == Convert.ToInt32(Ay) && j == Convert.ToInt32(Ax))   // Drawing the game screen
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write("A");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }

                                else if (i == Convert.ToInt32(By) && j == Convert.ToInt32(Bx))
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write("B");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }

                                else if (i == Convert.ToInt32(Cy) && j == Convert.ToInt32(Cx))
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write("C");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }

                                else if (i == 0 && j == 0)
                                {
                                    Console.Write("+");
                                }
                                else if (j == 0)
                                {
                                    Console.Write("|");
                                }
                                else if (i == 0)
                                {
                                    Console.Write("-");

                                }
                                else
                                {
                                    Console.Write(" ");
                                }


                            }


                            Console.WriteLine();

                        }
                        Console.WriteLine("   123456789012345678901234567890");

                        bulletAB = Math.Abs(Convert.ToDouble(bulletX) * (Convert.ToDouble(Ay) - Convert.ToDouble(By)) + Convert.ToDouble(Ax) * (Convert.ToDouble(By) - Convert.ToDouble(bulletY))
                            + Convert.ToDouble(Bx) * (Convert.ToDouble(bulletY) - Convert.ToDouble(Ay))) / 2.0;

                        bulletAC = Math.Abs(Convert.ToDouble(bulletX) * (Convert.ToDouble(Ay) - Convert.ToDouble(Cy)) + Convert.ToDouble(Ax) * (Convert.ToDouble(Cy) - Convert.ToDouble(bulletY)) // Areas of three corners of triangle and bullet
                            + Convert.ToDouble(Cx) * (Convert.ToDouble(bulletY) - Convert.ToDouble(Ay))) / 2.0;

                        bulletBC = Math.Abs(Convert.ToDouble(bulletX) * (Convert.ToDouble(By) - Convert.ToDouble(Cy)) + Convert.ToDouble(Bx) * (Convert.ToDouble(Cy) - Convert.ToDouble(bulletY))
                            + Convert.ToDouble(Cx) * (Convert.ToDouble(bulletY) - Convert.ToDouble(By))) / 2.0;

                        bulletTrianglesArea = bulletAB + bulletAC + bulletBC;

                        if (bulletTrianglesArea > shipArea)   // Checking if the ship survived
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine();
                            Console.WriteLine("Your ship is survived! " + Convert.ToString(shipArea) + " points gained");
                            Console.WriteLine("Total Score is: " + shipArea);
                            Console.WriteLine();



                            if (shipArea > scoreboardFirstPoint)
                            {
                                Console.Write("Enter Your name:");
                                string newPlayer = Console.ReadLine();
                                scoreboardThirdName = scoreboardSecondName;
                                scoreboardSecondName = scoreboardFirstName;
                                scoreboardFirstName = newPlayer;

                                scoreboardThirdPoint = scoreboardSecondPoint;
                                scoreboardSecondPoint = scoreboardFirstPoint;
                                scoreboardFirstPoint = Convert.ToDouble(shipArea);
                            }

                            else if (shipArea > scoreboardSecondPoint && shipArea <= scoreboardFirstPoint)
                            {
                                Console.Write("Enter Your name:");
                                string newPlayer = Console.ReadLine();
                                scoreboardThirdName = scoreboardSecondName;
                                scoreboardSecondName = newPlayer;

                                scoreboardThirdPoint = scoreboardSecondPoint;
                                scoreboardSecondPoint = Convert.ToDouble(shipArea);                                 // Scoreboard operations

                            }

                            else if (shipArea > scoreboardThirdPoint && shipArea <= scoreboardSecondPoint)
                            {
                                Console.Write("Enter Your name:");
                                string newPlayer = Console.ReadLine();
                                scoreboardThirdName = newPlayer;

                                scoreboardThirdPoint = Convert.ToDouble(shipArea);
                            }

                            else
                            {
                                Console.WriteLine("You must perform better in order to take place in scoreboard.");
                            }

                            Console.WriteLine();

                            string whitespace = "";

                            Console.WriteLine("      Name                Score");
                            Console.WriteLine("--------------------------------------");
                            for (int i = 0; i < 25 - scoreboardFirstName.Length; i++)
                            {
                                whitespace += " ";
                            }

                            Console.WriteLine("   " + scoreboardFirstName + whitespace + Convert.ToString(scoreboardFirstPoint));

                            whitespace = "";
                            for (int i = 0; i < 25 - scoreboardSecondName.Length; i++)
                            {
                                whitespace += " ";
                            }
                            Console.WriteLine("   " + scoreboardSecondName + whitespace + Convert.ToString(scoreboardSecondPoint));      // Printing scoreboard

                            whitespace = "";
                            for (int i = 0; i < 25 - scoreboardThirdName.Length; i++)
                            {
                                whitespace += " ";
                            }
                            Console.WriteLine("   " + scoreboardThirdName + whitespace + Convert.ToString(scoreboardThirdPoint));


                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("In order to play again, you should define a new ship.");
                            Console.ResetColor();
                            Console.WriteLine();
                            isShipDefined = false;

                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Your ship sank!");
                            Console.WriteLine("Total Score is: 0");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("In order to play again, you should define a new ship.");     // Inform the user when the ship is sank
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.WriteLine();

                            isShipDefined = false;
                        }


                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("You have to define a ship first!");      // Printing error for trying the shoot when ship is not defined
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                }

                if (userOption == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                    string whitespace = "";

                    Console.WriteLine("      Name                Score");
                    Console.WriteLine("--------------------------------------");
                    for (int i = 0; i < 25 - scoreboardFirstName.Length; i++)
                    {
                        whitespace += " ";
                    }

                    Console.WriteLine("   " + scoreboardFirstName + whitespace + Convert.ToString(scoreboardFirstPoint));

                    whitespace = "";
                    for (int i = 0; i < 25 - scoreboardSecondName.Length; i++)
                    {
                        whitespace += " ";
                    }
                    Console.WriteLine("   " + scoreboardSecondName + whitespace + Convert.ToString(scoreboardSecondPoint));      // Printing scoreboard

                    whitespace = "";
                    for (int i = 0; i < 25 - scoreboardThirdName.Length; i++)
                    {
                        whitespace += " ";
                    }
                    Console.WriteLine("   " + scoreboardThirdName + whitespace + Convert.ToString(scoreboardThirdPoint));
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ResetColor();
                }

                if (userOption == 5)
                {
                    gameContinue = false;       // Exits game
                }

            }
        }
    }
}