public static class Kata
{
    public static int Pillars(int numPill, int dist, int width)
    {
        int SumDistance = 0;
        if (numPill==2)SumDistance=(dist*100);
        if (numPill>2)SumDistance=(numPill-2) * width + (numPill-1)*dist*100;
        return SumDistance;
    }
}