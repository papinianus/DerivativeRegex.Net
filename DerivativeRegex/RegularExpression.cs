namespace DerivativeRegex;

public abstract class RegularExpression
{
    public abstract bool HasEpsilon();
    public abstract RegularExpression Derive(char c);

    public static bool IsMatch(RegularExpression regex, IEnumerable<char> chars) =>
        chars.Aggregate(regex, (accum, current) => accum.Derive(current)).HasEpsilon();
}
