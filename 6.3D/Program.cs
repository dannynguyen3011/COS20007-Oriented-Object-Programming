using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;
using _6._3D;
using SplashKitSDK;
using Timer = SplashKitSDK.Timer;

namespace _6_3D
{
    public class Program
    {   

        public static void Main()
        {
            Window gameWindow = new Window("Food Terminator!", 800, 600); 

          
            bool gameStarted = false;
            bool gameover = false;

            // start and game over screens

            StartScreen startScreen = new StartScreen(gameWindow);
            GameOverScreen goScreen = new GameOverScreen(gameWindow, 0);

            //Score score = new Score();
            Player p = new Player();
            
            uint lastSpawnTimeFood = 5;
            uint lastSpawnTimeBomb = 5;
            uint lastSpawnTimeEnergy = 2;
            uint lastSpawnTimeDonut = 1;


            List<Food> list_food = new List<Food>();
            List<Energy> list_energy = new List<Energy>();
            List<Bomb> list_bomb = new List<Bomb>();
            List<Donut> list_donut = new List<Donut>();
            Bitmap background = new Bitmap("background", "bg.png");
            

            do
            {
                SplashKit.ClearScreen();
                SplashKit.ProcessEvents();
                SplashKit.LoadBitmap("background", "bg.png");




                //start game if start button is clicked

                if (!gameStarted)
                {
                    //draw start screen
                    startScreen.Draw();

                    if (startScreen.StartClicked)
                    {
                        gameStarted = true;
                    }
                }
                // check if game is over, if not then load game

                if (gameStarted)
                    {
                    //if start game, start drawing things
                        background.Draw(0, 0);
                        p.Draw();
                        p.Update(gameover);



                        //adding objects
                        //add food
                        if (SplashKit.CurrentTicks() - lastSpawnTimeFood >= 3000)
                        {
                            list_food.Add(new Food());
                            lastSpawnTimeFood = SplashKit.CurrentTicks();
                        }

                        
                        //add bomb
                        if (SplashKit.CurrentTicks() - lastSpawnTimeBomb >= 3000)
                        {

                            list_bomb.Add(new Bomb());
                            lastSpawnTimeBomb = SplashKit.CurrentTicks();

                        }


                        //add energy
                        if (SplashKit.CurrentTicks() - lastSpawnTimeEnergy >= 3000)
                        {

                            list_energy.Add(new Energy());
                            lastSpawnTimeEnergy = SplashKit.CurrentTicks();

                        }
                    //add donut
                    if (SplashKit.CurrentTicks() - lastSpawnTimeDonut >= 8000)
                    {

                        list_donut.Add(new Donut());
                        lastSpawnTimeDonut = SplashKit.CurrentTicks();

                    }


                    //check collision
                    //bomb collision
                    foreach (Bomb bomb in new List<Bomb>(list_bomb))
                        {
                            //make game harder
                            
                            bomb.Draw();
                            bomb.Update(gameover);


                            if (p.CollideBomb(bomb))
                            {
                                list_bomb.Remove(bomb);
                                p.TakeDamage();
                                
                            }

                        }

                        //energy collision
                        foreach (Energy energy in new List<Energy>(list_energy))
                        {
                        //make game harder
                        if (p.Score >= 20)
                        {
                            energy.speed = 0.5f;

                        }

                        energy.Draw();
                            energy.Update(gameover);

                            if (p.CollideEnergy(energy))
                            {
                            list_energy.Remove(energy);
                                p.GainLives();
                            }
                        }
                     

                        //food collision
                        foreach (Food food in new List<Food>(list_food))
                        {
                        //make game harder
                        if (p.Score >= 20)
                        {
                            food.speed = 0.5f;

                        }
                        food.Draw();
                            food.Update(gameover);

                            if (p.CollideFood(food))
                            {
                                list_food.Remove(food);

                                p.IncreaseScore();

                            }
                        }

                    //food collision
                    foreach (Donut donut in new List<Donut>(list_donut))
                    {
                        //make game harder
                        if (p.Score >= 20)
                        {
                            donut.speed = 0.5f;

                        }
                        donut.Draw();
                        donut.Update(gameover);

                        if (p.CollideDonut(donut))
                        {
                            list_donut.Remove(donut);

                            p.BuffScore();
                            p.GainLives();

                        }
                    }
                    //increase speed 




                    if (p.Lives <= 0)
                        {
                        p.SaveScore();
                            gameover = true;
                            goScreen.Draw(p.Score);
                            if (goScreen.RestartClicked)
                            {
                                gameover = false;
                                gameStarted = false;
                                goScreen.Reset(); 
                                p.Reset();

                            }
                        }
                    }

                
                    SplashKit.DrawText($"Lives : {p.Lives.ToString()}", Color.Yellow, "ThaleahFat.ttf", 30, 330, 20);
                    SplashKit.DrawText($"Score : {p.Score.ToString()}", Color.Yellow, "ThaleahFat.ttf", 30, 460, 20);
                    SplashKit.DrawText($"High Score : {p.Hscore.ToString()}", Color.Red, "ThaleahFat.ttf", 30, 600, 20);
                    //SplashKit.TimerStarted(Timer)
                    SplashKit.DrawText("Food Terminator", SplashKitSDK.Color.Blue, 650, 0);
                    SplashKit.RefreshScreen();
                    SplashKit.ClearScreen();
                } while (!SplashKit.WindowCloseRequested("Food Terminator!")) ;
            }
    }
}
 