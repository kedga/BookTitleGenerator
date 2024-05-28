using SentenceBuilding;

namespace BookTitleGenerator.DataSeed;

public class BookSubtitlePatterns : SentencePattern
{
	public static SentenceBuilder Empty() => new ();

	public static string BookSubtitlePattern1() => new SentenceBuilder() // A Sage's Examination of Justice after Undermining her Carpenter / A Psychologist's Majestic Conversation of Diligence before Exploiting her Gardener / One Janitor's Investigation of Honesty while Betraying his Lover
		.PickOne(new RegularWord("one"), new Article(ArticleType.Indefinite))
		.AddRandom(Words.TypeOfPerson).IsPossesive()
		.AddRandom(Words.PlaceAdjective).IsOptional(7)
		.AddRandom(Words.ChallengingEngagement)
		.Add("of")
		.AddRandom(Words.Concept)
		.PickOne(WhileDoingHisTradesman, Empty)
		.Build().CapitalizeFirst();

	public static SentenceBuilder WhileDoingHisTradesman() => new SentenceBuilder()
		.PickOne("while", "after", "before")
		.AddRandom(Words.Doing)
		.PickOne("his", "her")
		.AddRandom(Words.Tradesman, Words.FamilyMember);


	public static string BookSubtitlePattern2() => new SentenceBuilder() // A Romance Cookbook / A Biography
		.AddArticle(ArticleType.Indefinite)
		.AddRandom(Words.Genre).IsOptional()
		.AddRandom(Words.TypeOfBook)
		.Build().CapitalizeFirst();
	public static string BookSubtitlePattern4() => new SentenceBuilder() // A Fantasy Masterpiece / A Poetry Milestone
		.AddArticle(ArticleType.Indefinite)
		.AddRandom(Words.Genre)
		.AddRandom(Words.BookAdjective)
		.Build().CapitalizeFirst();
	public static string BookSubtitlePattern5() => new SentenceBuilder() // A Niece's Journal / A Boss's Pamphlet on Open-mindedness
		.AddArticle(ArticleType.Indefinite)
		.AddRandom(Words.FamilyMember, Words.Tradesman).IsPossesive()
		.AddRandom(Words.TypeOfBook)
		.PickOne(OnConcept, Empty)
		.Build().CapitalizeFirst();
		public static SentenceBuilder OnConcept() => new SentenceBuilder()
			.Add("on")
			.AddRandom(Words.Concept);
	public static string BookSubtitlePattern6() => new SentenceBuilder() // A Wife's Battle of Faith / The Galactic War for Peace / A Mentor's Struggle for Intelligence / A Beautiful War of Forgiveness / A Daughter's Expectation of Love
		.AddArticle(ArticleType.Random)
		.PickOne(TypeOfPersons, Familymembers, Adjective)
		.AddRandom(Words.ConceptOf)
		.PickOne("for", "of")
		.AddRandom(Words.Concept)
		.Build().CapitalizeFirst();
		public static SentenceBuilder Adjective() => new SentenceBuilder()
				.AddRandom(Words.Adjective);
		public static SentenceBuilder TypeOfPersons() => new SentenceBuilder()
				.AddRandom(Words.TypeOfPerson).IsPossesive();
		public static SentenceBuilder Familymembers() => new SentenceBuilder()
				.AddRandom(Words.FamilyMember).IsPossesive();

	public static string BookSubtitlePattern7() => new SentenceBuilder() // How to Die Gently, Linger Patiently, and Awaken Eloquently / How to Eat Softly, Swim Anxiously, and Breathe Rapidly / How to Brush Your Table, Cook Yourself, and Sigh Frequently"
		.Add("How to")
		.PickOne(VerbAdverb, DoYourThing, DoYourself, VerbAtConcept)
		.AddPunctuation(PunctuationType.Comma)
		.PickOne(VerbAdverb, DoYourThing, DoYourself, VerbAtConcept)
		.AddPunctuation(PunctuationType.Comma)
		.Add("and")
		.PickOne(VerbAdverb)
		.Build().CapitalizeFirst();

	public static SentenceBuilder VerbAdverb() => new SentenceBuilder()
		.AddRandom(Words.Verb)
		.AddRandom(Words.Adverb);
	public static SentenceBuilder DoYourThing() => new SentenceBuilder()
		.AddRandom(Words.DoToYourself)
		.Add("Your")
		.AddRandom(Words.Object, Words.FamilyMember).Pluralize(true);
	public static SentenceBuilder DoYourself() => new SentenceBuilder()
		.AddRandom(Words.DoToYourself)
		.Add("Yourself");
	public static SentenceBuilder VerbAtConcept() => new SentenceBuilder()
		.AddRandom(Words.VerbAt)
		.Add("at")
		.AddRandom(Words.Domain);

	
}
