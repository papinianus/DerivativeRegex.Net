// See https://aka.ms/new-console-template for more information


using DerivativeRegex;

var samples = new[]
{
    (new Concat(new Star(new Chr('a')), new Chr('b')),
        [
            "ab",
            "aab",
            "b",
            "bb"
        ]),
    (WaterServer(),
        [
            "ウォーターサーバー",
            "ウォータサーバー",
            "ウォーターサーバ",
            "ウォータサーバ",
            "ウォーターーサーバーー",
            "ウォターサーバー"
        ]),
    (DottedTo(),
        new[]
        {
            "ありがとう",
            "おりごとう",
            "セイッ！",
        }),
};
foreach (var sample in samples)
{
    foreach (var test in sample.Item2)
    {
        var res = RegularExpression.IsMatch(sample.Item1, test);
        Console.WriteLine($"{test} => {res}");
    }
}
Console.WriteLine($"{Environment.NewLine}Exit;");
return;

static RegularExpression WaterServer()
{
    // "ウォーター*サーバー*"
    var water = new Concat( 
        new Chr('ウ'), 
        new Concat(
            new Chr('ォ'),
            new Concat(
                new Chr('ー'),
                new Concat(
                    new Chr('タ'),
                    new Star(
                        new Chr('ー')
                    )))));
    var server = new Concat(
        new Chr('サ'),
        new Concat(
            new Chr('ー'),
            new Concat(
                new Chr('バ'),
                new Star(
                    new Chr('ー')
                ))));
    return new Concat(water, server);
}

static RegularExpression DottedTo() =>
    // "...とう"
    new Concat(
        new Dot(),
        new Concat(
            new Dot(),
            new Concat(
                new Dot(),
                new Concat(
                    new Chr('と'),
                    new Chr('う')
                ))));
