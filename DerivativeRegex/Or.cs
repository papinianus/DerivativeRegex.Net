namespace DerivativeRegex;

public class Or(RegularExpression left, RegularExpression right) : RegularExpression
{
    private RegularExpression Left { get; } = left;
    private RegularExpression Right { get; } = right;

    public override bool HasEpsilon() => Left.HasEpsilon() || Right.HasEpsilon();

    public override RegularExpression Derive(char c) => new Or(Left.Derive(c), Right.Derive(c));
}