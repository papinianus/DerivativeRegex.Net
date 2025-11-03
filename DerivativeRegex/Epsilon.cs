namespace DerivativeRegex;

public class Epsilon : RegularExpression
{
    public override bool HasEpsilon() => true;
    public override RegularExpression Derive(char _) => new EmptySet();
}