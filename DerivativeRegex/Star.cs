namespace DerivativeRegex;

public class Star(RegularExpression left) : RegularExpression
{
    private RegularExpression Left { get; } = left;

    public override bool HasEpsilon() => true;

    public override RegularExpression Derive(char c) => new Concat(Left.Derive(c), this);
}
