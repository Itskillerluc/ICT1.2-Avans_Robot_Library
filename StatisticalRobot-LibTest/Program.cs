// Init

var knipperLed = Devices.Digital.BlinkLed(5, 100);

while (true)
{
    knipperLed.Update();

    Robot.Wait(1);
}
