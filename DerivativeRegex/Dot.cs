namespace DerivativeRegex;

public class Dot : RegularExpression
{
    public override bool HasEpsilon() => false;
    public override RegularExpression Derive(char _) => new Epsilon();
}