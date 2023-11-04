using MySql.Data.MySqlClient;

namespace WinFormsApp3;

public partial class Form1 : Form
{

    Elevator_.Data.Connection con = new Elevator_.Data.Connection();
    private int doorMovement = 5;
    private int doorPosition = 0;
    private int originalDoorPosition;
    private bool floorOneDoor = false;
    private bool floorGroundDoor = false;
    private bool elevatorFloor = true;

    public Form1()
    {
        InitializeComponent();
        originalDoorPosition = leftDoorDown.Left;
        floorTxtUp.Text = (elevatorFloor ? 1 : 0).ToString();




    }

    private void elevatorDoorOpen_Tick(object sender, EventArgs e)
    {

        PictureBox leftDoor = elevatorFloor ? leftDoorUp : leftDoorDown;
        PictureBox rightDoor = elevatorFloor ? rightDoorUp : rightDoorDown;
        bool doorStatus = elevatorFloor ? floorOneDoor : floorGroundDoor;


        if (doorPosition < 80 && !doorStatus)
        {
            leftDoor.Left -= doorMovement;
            rightDoor.Left += doorMovement;
            doorPosition += doorMovement;


        }

        else
        {
            elevatorDoorOpen.Stop();
            doorPosition = 0;
            if (elevatorFloor)
            {
                floorOneDoor = true;
            }
            else
            {
                floorGroundDoor = true;
            }
        }
    }

    private void doorOpenUp_Click(object sender, EventArgs e)
    {
        if (!elevatorDoorOpen.Enabled)
        {
            elevatorDoorOpen.Start();


        }

    }
    private void closeDoor_Tick(object sender, EventArgs e)
    {

        PictureBox leftDoor = elevatorFloor ? leftDoorUp : leftDoorDown;
        PictureBox rightDoor = elevatorFloor ? rightDoorUp : rightDoorDown;


        if (leftDoor.Left < originalDoorPosition)
        {
            leftDoor.Left += doorMovement;
            rightDoor.Left -= doorMovement;
        }
        else
        {
            closeDoor.Stop();
            if (elevatorFloor)
            {
                floorOneDoor = false;
            }
            else
            {
                floorGroundDoor = false;
            }
        }
    }

    private void doorCloseUp_Click(object sender, EventArgs e)
    {
        if (elevatorInterior.Top != leftDoorUp.Top)
        {
            if (!closeDoor.Enabled)
            {

                closeDoor.Start();
            }
        }
        else
        {
            if (!closeDoor.Enabled)
            {

                closeDoor.Start();
            }
        }

    }

    private async void groundFloor_Tick(object sender, EventArgs e)
    {
        if (floorOneDoor)
        {
            closeDoor.Start();
            await Task.Delay(2000);

        }
        if (elevatorInterior.Top <= leftDoorDown.Top)
        {
            elevatorInterior.Top += doorMovement;

        }

        else
        {

            groundFloor.Stop();
            elevatorFloor = false;
            floorTxtUp.Text = "G";
            elevatorDoorOpen.Start();
            await Task.Delay(2000);
            closeDoor.Start();

        }

    }

    private void floorGroundUp_Click(object sender, EventArgs e)
    {
        if (!groundFloor.Enabled && elevatorFloor)
        {

            groundFloor.Start();

        }
    }

    private void floorOneUp_Click(object sender, EventArgs e)
    {
        if (!groundFloor.Enabled && !elevatorFloor)
        {

            floorOne.Start();




        }
    }

    private async void floorOne_Tick(object sender, EventArgs e)
    {
        if (floorGroundDoor)
        {
            closeDoor.Start();
            await Task.Delay(2000);

        }
        if (elevatorInterior.Top > leftDoorUp.Top)
        {
            elevatorInterior.Top -= doorMovement;


        }
        else
        {
            floorOne.Stop();
            elevatorFloor = true;
            floorTxtUp.Text = "1";
            elevatorDoorOpen.Start();
            await Task.Delay(2000);
            closeDoor.Start();

        }
    }

    private void floorTxtUp_TextChanged(object sender, EventArgs e)
    {

    }

    private async void floorDownBtn_Click(object sender, EventArgs e)
    {
        if (!elevatorFloor)
        {
            floorOne.Start();

        }
        else
        {
            elevatorDoorOpen.Start();
            await Task.Delay(2000);
            closeDoor.Start();



        }
    }

    private async void floorUpBtn_Click(object sender, EventArgs e)
    {
        if (elevatorFloor)
        {
            groundFloor.Start();




        }
        else
        {
            elevatorDoorOpen.Start();
            await Task.Delay(2000);
            closeDoor.Start();



        }
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        try
        {


            con.insertData("asdasd");

            con.connClose();


        }
        catch (Exception)
        {
            MessageBox.Show("Failureeee");
        }
        finally
        {
            con.connClose();
        }
    }
}