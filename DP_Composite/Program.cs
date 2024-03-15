using DesignPatterns.Composite;

GitComponent mainBranch = new Branch("main");
GitComponent commitToMain1 = new Commit("82a79d4");
GitComponent commitToMain2 = new Commit("1c053ff");
GitComponent commitToMain3 = new Commit("1b5f953");
GitComponent commitToMain4 = new Commit("b1f9423");
mainBranch.Add(commitToMain1);
mainBranch.Add(commitToMain2);
mainBranch.Add(commitToMain3);
mainBranch.Add(commitToMain4);
mainBranch.Remove(commitToMain4);

GitComponent smallFeature = new Branch("small-feature");
mainBranch.Add(smallFeature);
GitComponent commitToSmallFeature1 = new Commit("22f71d3");
smallFeature.Add(commitToSmallFeature1);

GitComponent bigFeature = new Branch("big-feature");
mainBranch.Add(bigFeature);

GitComponent commitToBigFeature1 = new Commit("42a79d4");
GitComponent commitToBigFeature2 = new Commit("0c053ff");
GitComponent commitToBigFeature3 = new Commit("2b5f943");
GitComponent commitToBigFeature4 = new Commit("c1f9423");
GitComponent commitToBigFeature5 = new Commit("7b5f943");
GitComponent commitToBigFeature6 = new Commit("d1f9423");
bigFeature.Add(commitToBigFeature1);
bigFeature.Add(commitToBigFeature2);
bigFeature.Add(commitToBigFeature3);
bigFeature.Add(commitToBigFeature4);
bigFeature.Add(commitToBigFeature5);
bigFeature.Add(commitToBigFeature6);

Console.WriteLine("Small Feature Commit History:");
Console.WriteLine("-----------------------------");
smallFeature.ShowDetail();

Console.WriteLine("\nBig Feature Commit History:");
Console.WriteLine("---------------------------");
bigFeature.ShowDetail();

Console.WriteLine("\nFull Feature Commit History:");
Console.WriteLine("----------------------------");
mainBranch.ShowDetail();
