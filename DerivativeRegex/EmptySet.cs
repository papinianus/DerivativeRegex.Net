namespace DerivativeRegex;

public class EmptySet : RegularExpression
{
    // 空集合は epsilon ではない
    public override bool HasEpsilon() => false;
    
    // 空集合に対して任意の文字で微分して空集合を得る
    public override RegularExpression Derive(char _) => new EmptySet();
}
