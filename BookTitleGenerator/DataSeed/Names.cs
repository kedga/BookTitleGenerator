
namespace BookTitleGenerator.DataSeed;

public static class Names
{
	public static List<string> AllFirstNames =>
		[
			.. FirstNames,
			.. FirstNamesWeird,
			.. FirstNamesTolkien,
			.. FirstNamesSwedish
		];

	public static List<string> AllLastNames =>
		[
			.. LastNames,
			.. LastNamesPosh,
			.. LastNamesSwedish
		];

	public static readonly List<string> LastNames =
	[
		"Smith",
		"Johnson",
		"Williams",
		"Brown",
		"Jones",
		"Garcia",
		"Miller",
		"Davis",
		"Rodriguez",
		"Martinez",
		"Hernandez",
		"Lopez",
		"Gonzalez",
		"Wilson",
		"Anderson",
		"Thomas",
		"Taylor",
		"Moore",
		"Jackson",
		"White"
	];

	public static readonly List<string> LastNamesPosh =
	[
		"Montgomery",
		"Pendleton",
		"Fitzgerald",
		"Winthrop",
		"Cranston",
		"Featherstone",
		"Buckminster",
		"Davenport",
		"Peregrine",
		"Jenkins",
		"Harrington",
		"Worthington",
		"Cumberland",
		"Cholmondeley",
		"Witherspoon",
		"Cranford",
		"Fairfax",
		"Huntington",
		"Haverford",
		"Fitzwilliam",
		"Standish",
		"Montague",
		"Crawford",
		"Fitzgerald",
		"Chatsworth",
		"Wellington",
		"Weatherby",
		"Thornton",
		"Pembroke",
		"Hetherington",
		"Wadsworth",
		"Pennington",
		"Chumley",
		"Fitzroy"
	];

	public static readonly List<string> LastNamesSwedish =
	[
		"Andersson",
		"Johansson",
		"Karlsson",
		"Nilsson",
		"Eriksson",
		"Larsson",
		"Olsson",
		"Persson",
		"Gustafsson",
		"Svensson",
		"Jonsson",
		"Pettersson",
		"Berg",
		"Lindberg",
		"Bengtsson",
		"Lindström",
		"Olofsson",
		"Sjöberg",
		"Gunnarsson",
		"Björklund"
	];

	public static readonly List<string> FirstNames =
	[
		"Emma",
		"Liam",
		"Olivia",
		"Noah",
		"Ava",
		"Oliver",
		"Isabella",
		"Lucas",
		"Sophia",
		"Elijah",
		"Mia",
		"James",
		"Charlotte",
		"William",
		"Amelia",
		"Benjamin",
		"Harper",
		"Henry",
		"Evelyn",
		"Alexander"
	];

	public static readonly List<string> FirstNamesSwedish =
	[
		"Elsa",
		"Olle",
		"Astrid",
		"Gustav",
		"Ingrid",
		"Erik",
		"Freja",
		"Oskar",
		"Hedda",
		"Viktor",
		"Saga",
		"Emil",
		"Alva",
		"Axel",
		"Ebba",
		"Isak",
		"Maja",
		"Ludvig",
		"Nora",
		"Liam"
	];


	public static readonly List<string> FirstNamesTolkien =
	[
		"Frodo",
		"Gandalf",
		"Aragorn",
		"Legolas",
		"Gimli",
		"Bilbo",
		"Samwise",
		"Gollum",
		"Thorin",
		"Galadriel",
		"Eowyn",
		"Faramir",
		"Elrond",
		"Arwen",
		"Glorfindel",
		"Boromir",
		"Saruman",
		"Celeborn",
		"Éomer",
		"Theoden"
	];

	public static readonly List<string> FirstNamesWeird =
	[
		"Zephyr",
		"Persephone",
		"Balthazar",
		"Xanthe",
		"Cosmo",
		"Seraphina",
		"Jethro",
		"Ophelia",
		"Thorin",
		"Octavia",
		"Zephyrine",
		"Apollo",
		"Serendipity",
		"Wolfgang",
		"Xiomara",
		"Bartholomew",
		"Beatrix",
		"Nimbus",
		"Pandora",
		"Zoltan"
	];
}
