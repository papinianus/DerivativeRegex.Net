namespace DerivativeRegex;

public class Dot : RegularExpression
{
    // . は epsilon ではない
    public override bool HasEpsilon() => false;
    
    // 任意の文字で微分して epsilon を得る
    public override RegularExpression Derive(char _) => new Epsilon();
}
