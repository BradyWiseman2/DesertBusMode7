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
        
                                                                         //This is a super scuffed way
        Bitmap Render = new Bitmap(250, 250);                            //of doing this but I can't
                                                                         //spend all my time working
        Bitmap DesertMain = new Bitmap(Properties.Resources.DesertMain); //on the graphics       
        Bitmap DesertV1 = new Bitmap(Properties.Resources.DesertV1);
        Bitmap DesertV2 = new Bitmap(Properties.Resources.DesertV2);
        Bitmap DesertV3 = new Bitmap(Properties.Resources.DesertV3);
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
        Bitmap Lakitu = new Bitmap(Properties.Resources.Lakitu);


        double worldx = 0.5;
        double worldy = 0.01;
        double worlda = 1.55;
        double fnear = 0.01;
        double ffar = 0.7;
        double fovhalf = 3.1415 / 4;
        double ffarx1;
        double ffary1;
        double ffarx2;
        double ffary2;
        double fnearx1;
        double fneary1;
        double fnearx2;
        double fneary2;
        int SpinoutFrame = 1;
        int FrameDir = 1;
        int LakiY = 0;
        int LakiAnim;
        int LuigiY = 140;
        //The following variables are more game related, including the speed of the bus,
        //how long you've been driving, ect.
        bool GasPedal;
        int GameState = 0;
        double BusSpeed; //These are called Bus because of earlier plans but they apply to the kart
        double BusDrift; //the same way

        int TimeDriven; //in Seconds
        bool Forward;
        bool Back;
        bool TurnL;
        bool TurnR;




        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            Mode7Render();
        }
        private void MapViewer()
        {
            pBoxDesert.Enabled = false;
            pBoxDesert.Visible = false;
            pBoxPlains.Enabled = false;
            pBoxPlains.Visible = false;
            pBoxChocoMt.Enabled = false;
            pBoxChocoMt.Visible = false;
            pBoxBeach.Enabled = false;
            pBoxBeach.Visible = false;
            pBoxLake.Enabled = false;
            pBoxLake.Visible = false;
            pBoxGhost.Enabled = false;
            pBoxGhost.Visible = false;
            pBoxCastle.Enabled = false;
            pBoxCastle.Visible = false;
            pBoxRainbowRoad.Enabled = false;
            pBoxRainbowRoad.Visible = false;
            btnMapViewer.Enabled = false;
            btnMapViewer.Visible = false;
            pBoxTitle.Visible = false;
            ffar = 0.35;
            worlda = 1.55;
            GameState = 5;//makes all ui elements invisible, then enables the map viewer controls
        }
        private void MapChange(int Mapset)  //Changes the maps used to new ones every hour
        {
            switch (Mapset)
            {
                case 0:
                    DesertMain = (Properties.Resources.DesertMain);
                    DesertV1 = (Properties.Resources.DesertV1);
                    DesertV2 = (Properties.Resources.DesertV2);
                    DesertV3 = (Properties.Resources.DesertV3);
                    BackColor = Color.CadetBlue;
                    break;
                case 1:
                    DesertMain = (Properties.Resources.DonutPlainsMain);
                    DesertV1 = (Properties.Resources.DonutPlainsV1);
                    DesertV2 = (Properties.Resources.DonutPlainsV2);
                    DesertV3 = (Properties.Resources.DonutPlainsV3);
                    BackColor = Color.Cyan;
                    break;
                case 2:
                    DesertMain = (Properties.Resources.ChocoMtMain);
                    DesertV1 = (Properties.Resources.ChocoMtV1);
                    DesertV2 = (Properties.Resources.ChocoMtV2);
                    DesertV3 = (Properties.Resources.ChocoMtV3);
                    BackColor = Color.Goldenrod;
                    break;
                case 3:
                    DesertMain = (Properties.Resources.KoopaBeachMain);
                    DesertV1 = (Properties.Resources.KoopaBeachV1);
                    DesertV2 = (Properties.Resources.KoopaBeachMain);
                    DesertV3 = (Properties.Resources.KoopaBeachMain);
                    BackColor = Color.DeepSkyBlue;
                    break;
                case 4:
                    DesertMain = (Properties.Resources.VanillaLakeMain);
                    DesertV1 = (Properties.Resources.VanillaLakeV1);
                    DesertV2 = (Properties.Resources.VanillaLakeV2);
                    DesertV3 = (Properties.Resources.VanillaLakeMain);
                    break;
                case 5:
                    DesertMain = (Properties.Resources.GhostValleyMain);
                    DesertV1 = (Properties.Resources.GhostValleyV1);
                    DesertV2 = (Properties.Resources.GhostValleyV2);
                    DesertV3 = (Properties.Resources.GhostValleyMain);
                    BackColor = Color.Black;
                    break;
                case 6:
                    DesertMain = (Properties.Resources.BowserCastleMain);
                    DesertV1 = (Properties.Resources.BowserCastleV1);
                    DesertV2 = (Properties.Resources.BowserCastleV2);
                    DesertV3 = (Properties.Resources.BowserCastleMain);
                    BackColor = Color.OrangeRed;
                    break;
                case 7:
                    DesertMain = (Properties.Resources.RainbowRoadMain);
                    DesertV1 = (Properties.Resources.RainbowRoadMain);
                    DesertV2 = (Properties.Resources.RainbowRoadMain);
                    DesertV3 = (Properties.Resources.RainbowRoadMain);
                    BackColor = Color.Black;
                    break;
                case 8:
                    DesertMain = (Properties.Resources.Finish);
                    DesertV1 = (Properties.Resources.Finish);
                    DesertV2 = (Properties.Resources.Finish);
                    DesertV3 = (Properties.Resources.Finish);
                    break;
            }
        }

        private void Mode7Render() //This section is pretty heavily based on the following Youtube
                                   //video, with modifications made to improve the look, and
                                   //allow for an infinitely spanning world
                                   //https://www.youtube.com/watch?v=ybLZyY655iY
        {
            ffarx1 = (worldx + (Math.Cos(worlda - fovhalf)) * ffar);
            ffary1 = (worldy + (Math.Sin(worlda - fovhalf)) * ffar) * 0.2;

            ffarx2 = (worldx + (Math.Cos(worlda + fovhalf)) * ffar);
            ffary2 = (worldy + (Math.Sin(worlda + fovhalf)) * ffar) * 0.2;

            fnearx1 = (worldx + (Math.Cos(worlda - fovhalf)) * fnear);
            fneary1 = (worldy + (Math.Sin(worlda - fovhalf)) * fnear) * 0.2;

            fnearx2 = (worldx + (Math.Cos(worlda + fovhalf)) * fnear);
            fneary2 = (worldy + (Math.Sin(worlda + fovhalf)) * fnear) * 0.2;



            for (int y = 0; y < Render.Height; y += 2) //These 2 for loops combined will run for
                                                       //every pixel in the Render bitmap, so 250x250
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
                        pixel1 = pixel1 - (8 * ((int)Math.Floor((double)pixel1 / 8)));
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
                        default:
                            pixel2 = pixel2 - (144 * ((int)Math.Floor((double)pixel2 / 144)));
                            Render.SetPixel(x, y, PlaneMap5.GetPixel(pixel1, pixel2));
                            Render.SetPixel(x, y + 1, PlaneMap5.GetPixel(pixel1, pixel2));
                            break;




                    }


                }
            }
            if (GameState != 0 && GameState != 5 ) // If the gamestate isn't main menu or map viewer,
                                                   //display Luigi
            {
                using (Graphics g = Graphics.FromImage(Render))
                {




                    g.DrawImage(Sprite, new Point(115, LuigiY + rnd.Next(1, 4)));

                    if (LakiY > 0)
                    {
                        g.DrawImage(Lakitu, new Point(130, LakiY));
                    }

                }
            }
        
            
            pBoxRender.Image = Render;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch (GameState) //tests what state the game is in, and uses the appropriate controls
            {

                case 1:
                    switch (e.KeyCode)
                    {
                        case Keys.Up:
                            GasPedal = true;
                            GameState = 2;
                            BusDrift = 0.0008;
                            timerTimeDriven.Enabled = true;
                                break;
                    }
                    break;
                case 2:


                   switch (e.KeyCode)
                          {
                            case Keys.Up:
                             GasPedal = true;                             
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
                    break;

                case 5:
                    switch (e.KeyCode)
                    {
                        case Keys.Up:

                            Forward = true;
                            break;
                        case Keys.Down:
                            Back = true;
                            break;

                        case Keys.Right:
                            TurnR = true;
                            break;
                        case Keys.Left:
                            TurnL = true;
                            break;

                        case Keys.W:
                            ffar += 0.01;                                             
                            break;
                        case Keys.S:
                            ffar -= 0.01;                                                    
                            break;
                        case Keys.E:
                            fnear += 0.01;
                            Mode7Render();
                            break;
                        case Keys.D:
                            fnear -= 0.01;                                                 
                            break;                      
                    }
                    break;
            } 
     }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (GameState) 
            {
                case 2:
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
                    break;
                case 5:
                    switch (e.KeyCode)
                    {
                        case Keys.Up:

                            Forward = false;
                            break;
                        case Keys.Down:
                            Back = false;
                            break;

                        case Keys.Right:
                            TurnR = false;
                            break;
                        case Keys.Left:
                            TurnL = false;
                            break;
                    }
                            break;
          }
        }

        private void timerRender_Tick(object sender, EventArgs e)
        {
            switch (GameState)
            {
                case 0:
                    worlda += 0.005;
                    Mode7Render();
                    break;
                case 1:
                    Mode7Render();
                    break;
                case 2:
                    if (GasPedal == true && BusSpeed < 0.12) //If UP is held, accelerate until top speed
                    {
                        BusSpeed += 0.01;
                    }
                    if (GasPedal == false && BusSpeed > 0.00)
                    {
                        BusSpeed -= 0.002;
                    }


                    worldy += BusSpeed;
                    worldx -= BusDrift; //Apply the distance modifiers to your position

                    if (worldx > 0.72 || worldx < 0.28 || BusSpeed <= 0)
                    {
                        GameState = 3; //This means your Kart stalled and you lost :(
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
                        switch (rnd.Next(1, 250))
                        {
                            case 1:
                                PlaneMap5 = DesertV1;
                                break;
                            case 2:
                                PlaneMap5 = DesertV2;
                                break;
                            case 3:
                                PlaneMap5 = DesertV3;
                                break;
                            default:
                                PlaneMap5 = DesertMain;
                                break;
                        }
                        if (TimeDriven > 28810)
                        {
                            GameState = 4;
                        }
                    }

                    Mode7Render();           
                    break;
                case 3:        
                    if (BusSpeed > 0.00)
                    {
                        BusSpeed -= 0.004;
                    }
                    if (BusSpeed < 0)
                    {
                        BusSpeed = 0;
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
                    switch (SpinoutFrame) //Sets the frame for the spinout depending on the previous one
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

                    if (BusSpeed <= 0) //After the kart is stopped, the Lakitu animation starts
                    {
                        SpinoutFrame = -1;
                        BusDrift = 0;
                        switch (LakiAnim)
                        {
                            case 0:
                                LakiY+=6;
                                    if (LakiY > 120)
                                {
                                    LakiAnim++;
                                }
                                break;
                           
                            case 10:
                                LakiY -= 6;
                                LuigiY -= 6;
                                pBoxTransition.Left += 35;                           
                                if (LakiY < 5 && pBoxTransition.Left >0)
                                {
                                    LakiAnim++; //sets values back to what they should be at the start
                                    worldx = 0.5;
                                    worldy = 0.01;
                                    Sprite = Luigi;
                                    MapChange(0);
                                    PlaneMap1 = DesertMain;
                                    PlaneMap2 = DesertMain;
                                    PlaneMap3 = DesertMain;
                                    PlaneMap4 = DesertMain;
                                    PlaneMap5 = DesertMain;                                   
                                    TimeDriven = 0;
                                    timerTimeDriven.Enabled = false;
                                }
                                break;
                            case 11:
                                LakiY += 6;
                                LuigiY += 6;
                                pBoxTransition.Left += 35;
                                 if (LakiY > 120)
                                {
                                    LakiAnim++;
                                }
                                break;
                            case 12:
                                LakiY -= 6;
                                 if (LakiY < 0)
                                {
                                    GameState = 1;
                                    LakiAnim = 0;
                                    SpinoutFrame = 0;
                                    pBoxTransition.Left = -1201;


                                }
                                break;
                            default:
                                LakiAnim++;
                                break;

                        }
                        
                    }
                    Mode7Render();
                    break;
                case 4:
                    if (BusSpeed > 0.00)
                    {
                        BusSpeed -= 0.004;
                    }
                    if (BusSpeed < 0)
                    {
                        BusSpeed = 0;
                    }
                    worldy += BusSpeed;
                    worldx -= BusDrift;
                    if (BusDrift != 0)
                    {
                        BusDrift = 0;
                    }
              
                    Mode7Render();
                    pBoxWin.Visible = true; //Don't look at this its only for people who drive 8 hours
                    pBoxWin.Location = (new Point(551, -14));

                
                    break;
                case 5:
                    if (TurnL == true)
                    {
                        worlda -= 0.05;
                    }
                    if (TurnR == true)
                    {
                        worlda += 0.05;
                    }
                    if (Forward == true)
                    {
                        worldx += 0.04 * Math.Cos(worlda);
                        worldy += 0.04 * Math.Sin(worlda);
                        if (worldy < 0.00)
                        {
                            worldy = 4.99;
                        }
                        else if (worldy > 5.00)
                        {
                            worldy = 0.01;
                        }
                        if (worldx > 2.00)
                        {
                            worldx = 0.01;
                        }
                        else if (worldx < -1.00)
                        {
                            worldx = 1.99;
                        }
                    }
                    if (Back == true)
                    {
                        worldx -= 0.04 * Math.Cos(worlda);
                        worldy -= 0.04 * Math.Sin(worlda);
                        if (worldy < 0.00)
                        {
                            worldy = 0.99;
                        }
                        else if (worldy > 5.00)
                        {
                            worldy = 0.01;
                        }
                        if (worldx > 2.00)
                        {
                            worldx = -0.99;
                        }
                        else if (worldx < -1.00)
                        {
                            worldx = 1.99;
                        }
                    }
                    Mode7Render();
                    break;

            }
        }
        private void timerTimeDriven_Tick(object sender, EventArgs e)
        {
            TimeDriven++;
            switch (TimeDriven)
            {
                case 3600:
                    MapChange(1);
                    break;
                case 7200:
                    MapChange(2);
                    break;
                case 10800:
                    MapChange(3);
                    break;
                case 14400:
                    MapChange(4);
                    break;
                case 18000:
                    MapChange(5);
                    break;
                case 21600:
                    MapChange(6);
                    break;
                case 25200:
                    MapChange(7);
                    break;
                case 28800:
                    MapChange(8);
                    break;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameState = 1;
            ffar = 0.35;
            worlda = 1.55;
            pBoxTitle.Visible = false;
            btnStart.Visible = false;
            btnMapViewer.Visible = false;

        }

        private void btnMapViewer_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnStart.Enabled = false;
            btnMapViewer.Visible = false;
            btnMapViewer.Enabled = false;
            pBoxTitle.Image = (Properties.Resources.Map_Select);
            pBoxDesert.Enabled = true;
            pBoxDesert.Visible = true;
            pBoxPlains.Enabled = true;
            pBoxPlains.Visible = true;
            pBoxChocoMt.Enabled = true;
            pBoxChocoMt.Visible = true;
            pBoxBeach.Enabled = true;
            pBoxBeach.Visible = true;
            pBoxLake.Enabled = true;
            pBoxLake.Visible = true;
            pBoxGhost.Enabled = true;
            pBoxGhost.Visible = true;
            pBoxCastle.Enabled = true;
            pBoxCastle.Visible = true;
            pBoxRainbowRoad.Enabled = true;
            pBoxRainbowRoad.Visible = true;

        }

        private void pBoxDesert_Click(object sender, EventArgs e)
        {
            PlaneMap1 = DesertMain;
            PlaneMap2 = DesertMain;
            PlaneMap3 = DesertMain;
            PlaneMap4 = DesertMain;
            PlaneMap5 = DesertMain;
            MapViewer();
        }

        private void pBoxPlains_Click(object sender, EventArgs e)
        {
            PlaneMap1 = (Properties.Resources.DonutPlainsMain);
            PlaneMap2 = (Properties.Resources.DonutPlainsMain);
            PlaneMap3 = (Properties.Resources.DonutPlainsMain);
            PlaneMap4 = (Properties.Resources.DonutPlainsMain);
            PlaneMap5 = (Properties.Resources.DonutPlainsMain);
            BackColor = Color.Cyan;
            MapViewer();
        }

        private void pBoxChocoMt_Click(object sender, EventArgs e)
        {
            PlaneMap1 = (Properties.Resources.ChocoMtMain);
            PlaneMap2 = (Properties.Resources.ChocoMtMain);
            PlaneMap3 = (Properties.Resources.ChocoMtMain);
            PlaneMap4 = (Properties.Resources.ChocoMtMain);
            PlaneMap5 = (Properties.Resources.ChocoMtMain);
            MapViewer();
            BackColor = Color.Goldenrod;
        }

        private void pBoxBeach_Click(object sender, EventArgs e)
        {
            PlaneMap1 = (Properties.Resources.KoopaBeachMain);
            PlaneMap2 = (Properties.Resources.KoopaBeachMain);
            PlaneMap3 = (Properties.Resources.KoopaBeachMain);
            PlaneMap4 = (Properties.Resources.KoopaBeachMain);
            PlaneMap5 = (Properties.Resources.KoopaBeachMain);
            BackColor = Color.DeepSkyBlue;
            MapViewer();
        }

        private void pBoxLake_Click(object sender, EventArgs e)
        {
            PlaneMap1 = (Properties.Resources.VanillaLakeMain);
            PlaneMap2 = (Properties.Resources.VanillaLakeMain);
            PlaneMap3 = (Properties.Resources.VanillaLakeMain);
            PlaneMap4 = (Properties.Resources.VanillaLakeMain);
            PlaneMap5 = (Properties.Resources.VanillaLakeMain);
            BackColor = Color.DeepSkyBlue;
            MapViewer();
        }

        private void pBoxGhost_Click(object sender, EventArgs e)
        {
            PlaneMap1 = (Properties.Resources.GhostValleyMain);
            PlaneMap2 = (Properties.Resources.GhostValleyMain);
            PlaneMap3 = (Properties.Resources.GhostValleyMain);
            PlaneMap4 = (Properties.Resources.GhostValleyMain);
            PlaneMap5 = (Properties.Resources.GhostValleyMain);
            BackColor = Color.Black;
            MapViewer();
        }

        private void pBoxCastle_Click(object sender, EventArgs e)
        {
            PlaneMap1 = (Properties.Resources.BowserCastleMain);
            PlaneMap2 = (Properties.Resources.BowserCastleMain);
            PlaneMap3 = (Properties.Resources.BowserCastleMain);
            PlaneMap4 = (Properties.Resources.BowserCastleMain);
            PlaneMap5 = (Properties.Resources.BowserCastleMain);
            BackColor = Color.OrangeRed;
            MapViewer();
        }

        private void pBoxRainbowRoad_Click(object sender, EventArgs e)
        {
            PlaneMap1 = (Properties.Resources.RainbowRoadMain);
            PlaneMap2 = (Properties.Resources.RainbowRoadMain);
            PlaneMap3 = (Properties.Resources.RainbowRoadMain);
            PlaneMap4 = (Properties.Resources.RainbowRoadMain);
            PlaneMap5 = (Properties.Resources.RainbowRoadMain);
            BackColor = Color.Black;
            MapViewer();
        }
    }
}