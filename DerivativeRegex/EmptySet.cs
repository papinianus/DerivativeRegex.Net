namespace DerivativeRegex;

public class EmptySet : RegularExpression
{
    public override bool HasEpsilon() => false;
    public override RegularExpression Derive(char _) => new EmptySet();
}