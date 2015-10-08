using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public class Blinker
{

    private Timer withEventsField_tm = new Timer
    {
        Interval = 300,
        Enabled = false
    };
    public Timer tm
    {
        get { return withEventsField_tm; }
        set
        {
            if (withEventsField_tm != null)
            {
                withEventsField_tm.Tick -= tm_Tick;
            }
            withEventsField_tm = value;
            if (withEventsField_tm != null)
            {
                withEventsField_tm.Tick += tm_Tick;
            }
        }
    }
    Control ctl = null;
    int t = 6;
    Color c1 = Color.White;
    Color c2 = Color.Orange;

    Color origC = Color.White;
    public Blinker(Control c, Color color1, Color color2, int times = 6)
    {
        ctl = c;
        t = times;
        origC = ctl.BackColor;
        c1 = color1;
        c2 = color2;
        tm = withEventsField_tm;
        tm.Start();
    }

    private void tm_Tick(object sender, System.EventArgs e)
    {
        if (ctl != null)
        {
            if (t == 0)
            {
                tm.Stop();
                tm.Dispose();
                tm = null;
                ctl.BackColor = origC;
            }
            else
            {
                t -= 1;
                ctl.BackColor = t % 2 == 0 ? c1 : c2;
            }
        }
    }

    public static void Blink(Control c, Color color1, Color color2, int times = 6)
    {
        Blinker cls = new Blinker(c, color1, color2, times);
    }
}
