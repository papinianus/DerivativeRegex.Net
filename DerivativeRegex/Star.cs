namespace DerivativeRegex;

public class Star(RegularExpression left) : RegularExpression
{
    private RegularExpression Left { get; } = left;

    // * は、それが付された文字はなくてもよいので、それ自体で epsilon を導出できる
    public override bool HasEpsilon() => true;

    // 文字で微分するということは * に前置された(左側の)文字に対して微分した結果と * 自身との AND。
    // * は何度でも適用できるので自身を再帰的に右側に連接する
    public override RegularExpression Derive(char c) => new Concat(Left.Derive(c), this);
}
