
using GetRandomFromList;
using SentenceBuilding;

namespace BookTitleGenerator.DataSeed;

public class BookTitlePatterns : SentencePattern
{
	//static SentenceBuilder FullName() => new SentenceBuilder()
	//	.Add(Names.AllFirstNames.PickOne() + " " + Names.AllLastNames.PickOne());

	public static string BookTitlePattern0() => // Elrond Garcia and the Hologram of Graciousness / Pandora Eriksson and the Butcher's Telescope / Beatrix Fitzwilliam and the Galactic Paintings
		new SentenceBuilder()
		.PickOne(Names.AllFirstNames.PickOne())
		.PickOne(Names.AllLastNames.PickOne())
		.Add("and")
		.AddArticle(ArticleType.Definite)
		.PickOne(PersonsObject, ObjectOfConcept, AdjectiveObject)
		.Build().CapitalizeFirst();
		static SentenceBuilder ObjectOfConcept() => new SentenceBuilder()
			.AddRandom(Words.Object)
			.Add("of")
			.AddRandom(Words.Concept);
		static SentenceBuilder PersonsObject() => new SentenceBuilder()
			.AddRandom(Words.TypeOfPerson).IsPossesive()
			.AddRandom(Words.Object).Pluralize(true);
		static SentenceBuilder AdjectiveObject() => new SentenceBuilder()
			.AddRandom(Words.Adjective)
			.AddRandom(Words.Object).Pluralize(true);

	public static string BookTitlePattern3() => // Midnight in front of the Beach of Justice and Empowerment / The Realm of Mystic Chandeliers
		new SentenceBuilder()
		.PickOne 
		(
			new SentenceBuilder()
			.AddRandom(Words.State)
			.AddRandom(Words.RelativeLocation)
			,
			new SentenceBuilder()
		)
		.AddArticle(ArticleType.Definite)
		.AddRandom(Words.Place)
		.PickOne(OfJusticeAndEmpowerment, OfSoothingPocketWatches)
		.Build().CapitalizeFirst();
		static SentenceBuilder OfJusticeAndEmpowerment() => new SentenceBuilder()
				.Add("of")
				.AddRandom(Words.Concept)
				.Add("and")
				.AddRandom(Words.Concept);
		static SentenceBuilder OfSoothingPocketWatches() => new SentenceBuilder()
				.Add("of")
				.AddRandom(Words.Adjective)
				.AddRandom(Words.Object).Pluralize();

	public static string BookTitlePattern4() => // Stethoscopes for Explorers / Funny Briefcases for Tropical Intellectuals
		new SentenceBuilder()
		.AddRandom(Words.Adjective).IsOptional()
		.AddRandom(Words.Object).Pluralize()
		.Add("for")
		.AddRandom(Words.Adjective).IsOptional()
		.AddRandom(Words.TypeOfPerson).Pluralize()
		.Build().CapitalizeFirst();

	static SentenceBuilder AdjectivePeople() => new SentenceBuilder()
		.AddRandom(Words.Adjective).IsOptional()
		.AddRandom(Words.TypeOfPerson).Pluralize();
	static SentenceBuilder FirstnamesFamilymember() => new SentenceBuilder()
		.AddRandom(Names.AllFirstNames).IsPossesive()
		.AddRandom(Words.FamilyMember);
	public static string BookTitlePattern5() => // Dancing / Majestic Rapture
		new SentenceBuilder()
		.AddRandom(Words.Adjective).IsOptional()
		.AddRandom(Words.Concept, Words.State, Words.Activity)
		.Build().CapitalizeFirst();
	public static string BookTitlePattern6() => // My Lover's Psychologist / The Father's Designer
		new SentenceBuilder()
		.PickOne("My", "The")
		.AddRandom(Words.FamilyMember, Words.Tradesman).IsPossesive()
		.AddRandom(Words.Tradesman, Words.FamilyMember, Words.Object)
		.Build().CapitalizeFirst();
	public static string BookTitlePattern8() => new SentenceBuilder() // Coaching the Cousins and Threatening the Waiters / Abusing the Scholars and Mentoring the Engineers
		.AddRandom(Words.Doing)
		.AddArticle(ArticleType.Definite)
		.AddRandom(Words.TypeOfPerson, Words.FamilyMember).Pluralize()
		.Add("and")
		.AddRandom(Words.Doing)
		.AddArticle(ArticleType.Definite)
		.AddRandom(Words.TypeOfPerson, Words.FamilyMember).Pluralize()
		.Build().CapitalizeFirst();
	public static string BookTitlePattern9() => new SentenceBuilder() // The Transcendent Review Compendium for Definitive Butchers / The Peerless Investigation Anthology for Supreme Janitors
		.AddArticle(ArticleType.Definite)
		.AddRandom(Words.BoastfulAdjective)
		.AddRandom(Words.ChallengingEngagement, Words.TypeOfPerson, Words.Object)
		.AddRandom(Words.TypeOfBook)
		.PickOne(dwadsad)
		.Build().CapitalizeFirst();
	static SentenceBuilder dwadsad() => new SentenceBuilder()
		.Add("for")
		.AddRandom(Words.BoastfulAdjective)
		.AddRandom(Words.TypeOfPerson).Pluralize();
}
