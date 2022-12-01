namespace DesertBusMode7
{
    public partial class Form1 : Form
    {
        //These variables are all used to render                                                 
        //the 3D plane. The worldx and worldy variables
        //are modified by moving forward or backward for y,
        //and left or right for x. During the normal game,
        //all others are not controlled by the player,
        //but may change based on what is happening in
        //the game. In the Map View mode, the player has
        //more or less free control over non calculated
        //variables.
        Bitmap PlaneMap1 = new Bitmap(Properties.Resources.DesertMain);
        Bitmap PlaneMap2 = new Bitmap(Properties.Resources.DesertMain);
        Bitmap PlaneMap3 = new Bitmap(Properties.Resources.DesertMain);
        Bitmap PlaneMap4 = new Bitmap(Properties.Resources.DesertMain);
        Bitmap PlaneMap5 = new Bitmap(Properties.Resources.DesertMain);
        Bitmap PlaneMap6 = new Bitmap(Properties.Resources.DesertMain);
        Bitmap PlaneMap7 = new Bitmap(Properties.Resources.DesertMain);
        Bitmap PlaneMap8 = new Bitmap(Properties.Resources.DesertMain);  //This is a super scuffed way
        Bitmap Render = new Bitmap(250, 250);                            //of doing this but I can't
                                                                         //spend all my time working
        Bitmap DesertMain = new Bitmap(Properties.Resources.DesertMain); //on the graphics
        Bitmap KoopaBeachMain = new Bitmap(Properties.Resources.KoopaBeachMain);
        Bitmap ChocoMtMain = new Bitmap(Properties.Resources.ChocoMtMain);
        Bitmap VanillaLakeMain = new Bitmap(Properties.Resources.VanillaLakeMain);
        Bitmap GhostValleyMain = new Bitmap(Properties.Resources.GhostValleyMain);
        Bitmap BowserCastleMain = new Bitmap(Properties.Resources.BowserCastleMain);
        Bitmap RainbowRoadMain = new Bitmap(Properties.Resources.RainbowRoadMain);
        Bitmap Sprite = new Bitmap(Properties.Resources.Luigi);
        Bitmap Luigi = new Bitmap(Properties.Resources.Luigi);
        Bitmap LuigiRight = new Bitmap(Properties.Resources.LuigiRight);
        Bitmap LuigiLeft = new Bitmap(Properties.Resources.LuigiLeft);
        Bitmap S1 = new Bitmap(Properties.Resources.S1);
        Bitmap S2 = new Bitmap(Properties.Resources.S2);
        Bitmap S3 = new Bitmap(Properties.Resources.S3);
        Bitmap S4 = new Bitmap(Properties.Resources.S4);
        Bitmap S5 = new Bitmap(Properties.Resources.S5);
        Bitmap S6 = new Bitmap(Properties.Resources.S6);
        Bitmap S7 = new Bitmap(Properties.Resources.S7);
        Bitmap S8 = new Bitmap(Properties.Resources.S8);
        Bitmap S9 = new Bitmap(Properties.Resources.S9);


        double worldx = 0.5;
        double worldy = 0.01;
        double worlda = 1.55;
        double fnear = 0.01;
        double ffar = 0.3;
        double fovhalf = 3.1415 / 4;
        double ffarx1;
        double ffary1;
        double ffarx2;
        double ffary2;
        double fnearx1;
        double fneary1;
        double fnearx2;
        double fneary2;
        //The following variables are more game related, including the speed of the bus,
        //how long you've been driving, ect.
        bool GasPedal;
        int GameState = 1;
        double BusSpeed;
        double BusDrift;
        int TimeDriven; //in Minutes
        int SpinoutFrame = 1;
        int FrameDir = 1;




        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            Mode7Render();
        }


        private void Mode7Render()
        {
            ffarx1 = (worldx + (Math.Cos(worlda - fovhalf)) * ffar);
            ffary1 = (worldy + (Math.Sin(worlda - fovhalf)) * ffar) * 0.2;

            ffarx2 = (worldx + (Math.Cos(worlda + fovhalf)) * ffar);
            ffary2 = (worldy + (Math.Sin(worlda + fovhalf)) * ffar) * 0.2;

            fnearx1 = (worldx + (Math.Cos(worlda - fovhalf)) * fnear);
            fneary1 = (worldy + (Math.Sin(worlda - fovhalf)) * fnear) * 0.2;

            fnearx2 = (worldx + (Math.Cos(worlda + fovhalf)) * fnear);
            fneary2 = (worldy + (Math.Sin(worlda + fovhalf)) * fnear) * 0.2;



            for (int y = 0; y < Render.Height - 50; y += 2)
            {
                double depth = ((double)y / ((double)Render.Height));

                double fstartX = ((ffarx1 - fnearx1) / (depth)) + fnearx1;
                double fstartY = ((ffary1 - fneary1) / (depth)) + fneary1;
                double fendX = ((ffarx2 - fnearx2) / (depth)) + fnearx2;
                double fendY = ((ffary2 - fneary2) / (depth)) + fneary2;
                for (int x = 0; x < Render.Width; x += 1)
                {
                    double width = ((double)x / ((double)Render.Width));

                    double samplex = (fendX - fstartX) * width + fstartX;
                    double sampley = (fendY - fstartY) * width + fstartY;

                    int pixel1 = (int)((samplex * PlaneMap1.Width));
                    int pixel2 = (int)((sampley * PlaneMap1.Height));

                    if (pixel1 > 151 || pixel1 < 1)
                    {
                        pixel1 = pixel1 - (9 * ((int)Math.Floor((double)pixel1 / 9)));
                    }


                    switch ((int)Math.Floor((double)pixel2 / PlaneMap1.Height))
                    {
                        case 0:
                            Render.SetPixel(x, y, PlaneMap1.GetPixel(pixel1, pixel2));
                            Render.SetPixel(x, y + 1, PlaneMap1.GetPixel(pixel1, pixel2));
                            break;
                        case 1:
                            pixel2 = pixel2 - (PlaneMap1.Height);
                            Render.SetPixel(x, y, PlaneMap2.GetPixel(pixel1, pixel2));
                            Render.SetPixel(x, y + 1, PlaneMap2.GetPixel(pixel1, pixel2));
                            break;
                        case 2:
                            pixel2 = pixel2 - (PlaneMap1.Height * 2);
                            Render.SetPixel(x, y, PlaneMap3.GetPixel(pixel1, pixel2));
                            Render.SetPixel(x, y + 1, PlaneMap3.GetPixel(pixel1, pixel2));
                            break;
                        case 3:
                            pixel2 = pixel2 - (PlaneMap1.Height * 3);
                            Render.SetPixel(x, y, PlaneMap4.GetPixel(pixel1, pixel2));
                            Render.SetPixel(x, y + 1, PlaneMap4.GetPixel(pixel1, pixel2));
                            break;
                        case 4:
                            pixel2 = pixel2 - (PlaneMap1.Height * 4);
                            Render.SetPixel(x, y, PlaneMap5.GetPixel(pixel1, pixel2));
                            Render.SetPixel(x, y + 1, PlaneMap5.GetPixel(pixel1, pixel2));
                            break;
                        case 5:
                            pixel2 = pixel2 - (PlaneMap1.Height * 5);
                            Render.SetPixel(x, y, PlaneMap6.GetPixel(pixel1, pixel2));
                            Render.SetPixel(x, y + 1, PlaneMap6.GetPixel(pixel1, pixel2));
                            break;
                        case 6:
                            pixel2 = pixel2 - (PlaneMap1.Height * 6);
                            Render.SetPixel(x, y, PlaneMap7.GetPixel(pixel1, pixel2));
                            Render.SetPixel(x, y + 1, PlaneMap7.GetPixel(pixel1, pixel2));
                            break;
                        case 7:
                            pixel2 = pixel2 - (PlaneMap1.Height * 7);
                            Render.SetPixel(x, y, PlaneMap8.GetPixel(pixel1, pixel2));
                            Render.SetPixel(x, y + 1, PlaneMap8.GetPixel(pixel1, pixel2));
                            break;
                        default:
                            pixel2 = pixel2 - (144 * ((int)Math.Floor((double)pixel2 / 144)));
                            Render.SetPixel(x, y, PlaneMap8.GetPixel(pixel1, pixel2));
                            Render.SetPixel(x, y + 1, PlaneMap8.GetPixel(pixel1, pixel2));
                            break;




                    }


                }
            }

            using (Graphics g = Graphics.FromImage(Render))
            {


                int y = rnd.Next(140, 142);

                g.DrawImage(Sprite, new Point(115, y));

            }

            pBoxRender.Image = Render;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    GasPedal = true;
                    if (GameState == 1)
                    {
                        BusSpeed = 0.001;
                        GameState = 2;                       
                    }                    
                    break;
                case Keys.Left:
                    BusDrift = -0.005;
                    Sprite = LuigiLeft;
                    break;
                case Keys.Right:
                    BusDrift = 0.005;
                    Sprite = LuigiRight;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        GasPedal = false;
                        break;
                    case Keys.Left:
                        BusDrift = 0.0008;
                        Sprite = Luigi;
                        break;
                    case Keys.Right:
                        BusDrift = 0.0008;
                        Sprite = Luigi;
                        break;
                }
            
        }

        private void timerRender_Tick(object sender, EventArgs e)
        {
            switch (GameState)
            {
                case 1:
                    break;
                case 2:
                    if (GasPedal == true && BusSpeed < 0.15)
                    {
                        BusSpeed += 0.01;
                    }
                    if (GasPedal == false && BusSpeed > 0.00)
                    {
                        BusSpeed -= 0.002;
                    }


                    worldy += BusSpeed;
                    worldx -= BusDrift;

                    if (worldx > 0.72 || worldx < 0.28 || BusSpeed <= 0)
                    {
                        GameState = 3;
                    }

                    if (worldy < 0.00)
                    {
                        worldy = 0.99;
                    }
                    else if (worldy > 5.00)
                    {
                        worldy = 0.01;
                        PlaneMap1 = PlaneMap2;
                        PlaneMap2 = PlaneMap3;
                        PlaneMap3 = PlaneMap4;
                        PlaneMap4 = PlaneMap5;
                        PlaneMap5 = PlaneMap6;
                        PlaneMap6 = PlaneMap7;
                        PlaneMap7 = PlaneMap8;

                        switch (rnd.Next(1, 8))
                        {
                            case 1:
                                PlaneMap8 = KoopaBeachMain;
                                break;
                            case 2:
                                PlaneMap8 = BowserCastleMain;
                                break;
                            case 3:
                                PlaneMap8 = ChocoMtMain;
                                break;
                            case 4:
                                PlaneMap8 = GhostValleyMain;
                                break;
                            case 5:
                                PlaneMap8 = VanillaLakeMain;
                                break;
                            case 6:
                                PlaneMap8 = RainbowRoadMain;
                                break;
                            default:
                                PlaneMap8 = DesertMain;
                                break;
                        }
                    }
                    Mode7Render();           
                    break;
                case 3:           
                    if (BusSpeed > 0.00)
                    {
                        BusSpeed -= 0.004;
                    }
                    worldy += BusSpeed;
                    worldx -= BusDrift;
                    if (BusDrift > 0)
                    {
                        BusDrift -= 0.0001;
                    }
                    else if (BusDrift < 0)
                    {
                        BusDrift += 0.0001;
                    }
                    switch (SpinoutFrame)
                    {
                        case 0:
                            Sprite = Luigi;
                            FrameDir = 1;
                            SpinoutFrame += FrameDir;
                            break;
                        case 1:
                            Sprite = S1;                                                       
                            Sprite.RotateFlip(RotateFlipType.RotateNoneFlipX);                            
                            SpinoutFrame += FrameDir;                           
                            break;
                        case 2:
                            Sprite = S3;
                            Sprite.RotateFlip(RotateFlipType.RotateNoneFlipX);                            
                            SpinoutFrame += FrameDir;
                            break;
                        case 3:
                            Sprite = S5;                                                  
                            Sprite.RotateFlip(RotateFlipType.RotateNoneFlipX);                            
                            SpinoutFrame += FrameDir;
                            break;
                        case 4:
                            Sprite = S7;                                                
                            Sprite.RotateFlip(RotateFlipType.RotateNoneFlipX);                            
                            SpinoutFrame += FrameDir;
                            break;
                        case 5:
                            Sprite = S9;
                            FrameDir = -1;
                            SpinoutFrame += FrameDir;                        
                            break;
                      
                    }

                    if (BusSpeed <= 0)
                    {
                        SpinoutFrame = -1;
                        
                    }

                    Mode7Render();

                    break;


            }

        }
    }
}
     
    


