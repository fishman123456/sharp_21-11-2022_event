class Count_
{
    public delegate void Count_one(int co);

    public event Count_one Co_ev;


    public void circle(int co)
    {

        for (int i = 0; i <= 1200; i++)
        {
            if (i == co)
            {
                Co_ev(i);
            }
        }
    }
}