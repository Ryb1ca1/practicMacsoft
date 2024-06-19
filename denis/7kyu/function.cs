public static class Kata {
    // * PRELOADED:
    // public enum Value { Scissors, Paper, Rock, Lizard, Spock }
    // public enum Ordering { LT, EQ, GT }

    public static Ordering Rpsls(Value a, Value b) {
        if(a == Value.Rock)
            switch (b)
            {
                case Value.Rock:
                return Ordering.EQ;
                case Value.Paper:
                return Ordering.LT;
                case Value.Scissors:
                return Ordering.GT;
                case Value.Lizard:
                return Ordering.GT;
                case Value.Spock:
                return Ordering.LT;
            }
        if(a == Value.Paper)
            switch (b)
            {
                case Value.Rock:
                return Ordering.GT;
                case Value.Paper:
                return Ordering.EQ;
                case Value.Scissors:
                return Ordering.LT;
                case Value.Lizard:
                return Ordering.LT;
                case Value.Spock:
                return Ordering.GT;
            }
        if(a == Value.Scissors)
            switch (b)
            {
                case Value.Rock:
                return Ordering.LT;
                case Value.Paper:
                return Ordering.GT;
                case Value.Scissors:
                return Ordering.EQ;
                case Value.Lizard:
                return Ordering.GT;
                case Value.Spock:
                return Ordering.LT;
            }
        if(a == Value.Lizard)
            switch (b)
            {
                case Value.Rock:
                return Ordering.LT;
                case Value.Paper:
                return Ordering.GT;
                case Value.Scissors:
                return Ordering.LT;
                case Value.Lizard:
                return Ordering.EQ;
                case Value.Spock:
                return Ordering.GT;
            }
        if(a == Value.Spock)
            switch (b)
            {
                case Value.Rock:
                return Ordering.GT;
                case Value.Paper:
                return Ordering.LT;
                case Value.Scissors:
                return Ordering.GT;
                case Value.Lizard:
                return Ordering.LT;
                case Value.Spock:
                return Ordering.EQ;
            }
        return Ordering.EQ;
    }
}