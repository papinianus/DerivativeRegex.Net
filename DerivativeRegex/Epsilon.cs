namespace DerivativeRegex;

public class Epsilon : RegularExpression
{
    public override bool HasEpsilon() => true;
    
    // epsilon を任意の文字で微分すると空集合を得る
    public override RegularExpression Derive(char _) => new EmptySet();
}
