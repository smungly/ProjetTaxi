namespace Projet_Gerer_Taxi
{
    partial class Res
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Res));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTO = new System.Windows.Forms.Label();
            this.lblfrom = new System.Windows.Forms.Label();
            this.DESTI = new Bunifu.Framework.UI.BunifuDropdown();
            this.ENDROITPICK = new Bunifu.Framework.UI.BunifuDropdown();
            this.IDMat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.IDClient = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.IDChaffeur = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblreserv = new System.Windows.Forms.Label();
            this.HeureReser = new System.Windows.Forms.Label();
            this.HeurePick = new System.Windows.Forms.DateTimePicker();
            this.btnsave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DBstate2 = new System.Windows.Forms.PictureBox();
            this.DBstate1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbarrow = new System.Windows.Forms.PictureBox();
            this.ploc = new System.Windows.Forms.PictureBox();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnhelp = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.Label();
            this.error2 = new System.Windows.Forms.Label();
            this.error3 = new System.Windows.Forms.Label();
            this.error4 = new System.Windows.Forms.Label();
            this.error5 = new System.Windows.Forms.Label();
            this.error6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DBstate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBstate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbarrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ploc)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(149, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "ID CLIENT :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(118, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 39;
            this.label2.Text = "ID CHAUFFEUR :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(139, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "MATRICULE:";
            // 
            // lblTO
            // 
            this.lblTO.AutoSize = true;
            this.lblTO.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic);
            this.lblTO.Location = new System.Drawing.Point(438, 214);
            this.lblTO.Name = "lblTO";
            this.lblTO.Size = new System.Drawing.Size(37, 22);
            this.lblTO.TabIndex = 37;
            this.lblTO.Text = "DE :";
            this.lblTO.Click += new System.EventHandler(this.lblTO_Click);
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic);
            this.lblfrom.Location = new System.Drawing.Point(673, 324);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(27, 22);
            this.lblfrom.TabIndex = 36;
            this.lblfrom.Text = ": À";
            // 
            // DESTI
            // 
            this.DESTI.BackColor = System.Drawing.Color.Transparent;
            this.DESTI.BorderRadius = 3;
            this.DESTI.DisabledColor = System.Drawing.Color.Gray;
            this.DESTI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DESTI.ForeColor = System.Drawing.Color.White;
            this.DESTI.Items = new string[] {
        "Aucun",
        "Abercrombie",
        "Albion",
        "Alma",
        "Amaury",
        "Amitie",
        "Anse Jonchee",
        "Antoinette",
        "Argy",
        "Arsenal",
        "Astroea",
        "Bagatelle",
        "Baie du Cap",
        "Baie du Tombeau",
        "Baie Mannioc",
        "Baillache",
        "Bain des Dames",
        "Balisson",
        "Bambous",
        "Bambous Virieux",
        "Bananes",
        "Barachois",
        "Barkly",
        "Bar le Duc",
        "Barlow",
        "Bassin Louloup",
        "Batimarais",
        "Baty Mare",
        "Beau-Vallon",
        "Beau Bassin",
        "Beau Bois",
        "Beau Champ",
        "Beau Fond",
        "Beau Mangue",
        "Beau Manguier",
        "Beau Plan",
        "Beau Sejour",
        "Beau Site",
        "Beau Vallon",
        "Beaux Songes",
        "Bel Air",
        "Belle-Vue",
        "Belle Etoile",
        "Belle Isle",
        "Belle Mare",
        "Belle Ombre",
        "Belle Rose",
        "Belle Terre",
        "Belle Vue",
        "Belle Vue Allendy",
        "Belle Vue Harel",
        "Belle Vue Maurel",
        "Belle Vue Pilot",
        "Bell Village",
        "Bell Village Station",
        "Belmont",
        "Bel Ombre",
        "Belvedere",
        "Bel Étang",
        "Bestel",
        "Bety",
        "Black River",
        "Bois Chéri",
        "Bois d\'Oiseau",
        "Bois Mangue",
        "Bois Marchand",
        "Bois Marchand Station",
        "Bois Pignolet",
        "Bois Pougnet",
        "Bois Rouge",
        "Bois Sec",
        "Bon Accueil",
        "Bon Air",
        "Bon Courage",
        "Bon Espoir",
        "Bon Manioc",
        "Bonne Mere",
        "Bonne Terre",
        "Bonne Veine",
        "Bort Lois",
        "Bouchon",
        "Bramsthan",
        "Bras d\'Eau",
        "Bras d’Eau",
        "Brisee Verdiere",
        "Britannia",
        "Bémanique",
        "Bénarès",
        "Cachette",
        "Calebasses",
        "Camp Accacia",
        "Camp Auguste",
        "Campbell",
        "Camp Berthaud",
        "Camp Bestel",
        "Camp Bonnemère",
        "Camp Bouillon",
        "Camp Carol",
        "Camp Cassia",
        "Camp Caval",
        "Camp Creoles",
        "Camp Créole",
        "Camp Créoles",
        "Camp de Masque",
        "Camp de Masque Pave",
        "Camp de Masque Station",
        "Camp des Embrevades",
        "Camp Diable",
        "Camp Fouquereaux",
        "Camp Garreau",
        "Camp Ithier",
        "Camp Jardin",
        "Camp La Savanne",
        "Camp Malgache",
        "Camp Mapou",
        "Camp Marcelin",
        "Camp Poorun",
        "Camp Roches",
        "Camp Sonah",
        "Camp Thorel",
        "Camp Thoret",
        "Camp Yoloff",
        "Candos",
        "Canot",
        "Cap Malheureux",
        "Caroline",
        "Carreau La Liane",
        "Carreau Lalo",
        "Cascavelle",
        "Casela",
        "Cassis",
        "Cent Gaulettes",
        "Centre de Flacq",
        "Chamarel",
        "Chamouny",
        "Champ de Mars",
        "Chantenay",
        "Chemin Grenier",
        "Choisy",
        "Chébel",
        "Cinq Arpents",
        "Circonstance",
        "Cite La Cure",
        "Cité Valijée",
        "Clarence",
        "Clarens",
        "Clavet",
        "Cluny",
        "Clémencia",
        "Congomah",
        "Constance",
        "Coquinbourg",
        "Coromandel",
        "Coteau Raffin",
        "Coteau Rafin",
        "Cote d\'Or",
        "Cottage",
        "Crève Coeur",
        "Curepipe",
        "Côte d’Or",
        "D\'Epinay",
        "Dagotière",
        "Dalais",
        "Deep River",
        "Deux Bras",
        "Deux Frères",
        "Dubreuil",
        "D’Epinay",
        "Eau Bleue",
        "Eau Bonne",
        "Eaux Coulée",
        "Ebene",
        "Ebene City",
        "Ebene CyberCity",
        "Ecroignard",
        "Eighteenth Mile Village",
        "Engrais Cathan",
        "Engrais Martial",
        "Ernest Florent",
        "Escalier",
        "Espérance Trébuchet",
        "Etoile",
        "Ferney",
        "Ferney Mill",
        "Flacq",
        "Flic-en-Flacq",
        "Flic en Flac",
        "Floreal",
        "Fond du Sac",
        "Fontenelle",
        "Forbach",
        "Forest Side",
        "Frederica",
        "Gaboola",
        "Germain",
        "Glen Park",
        "Gokoola",
        "Goodlands",
        "Grand Baie",
        "Grand Bel Air",
        "Grand Bois",
        "Grand dans Fond",
        "Grande Baie",
        "Grande Case Noyale",
        "Grande Gaube",
        "Grande Pointe aux Piments",
        "Grande Retraite",
        "Grande Retraits",
        "Grande Reviere Sud Est",
        "Grande Riviere Noire",
        "Grande Rivière Sud Est",
        "Grande Rosalie",
        "Grand Gaube",
        "Grand River",
        "Grand River North West",
        "Grand River South East",
        "Grand Rivière Noire",
        "Grand Sable",
        "Gros Billot",
        "Gros Bois",
        "Gros Cailloux",
        "Haut de Flacq",
        "Haute Rive",
        "Haut Rive",
        "Helvétia",
        "Henrietta",
        "Hermitage",
        "Hervé",
        "Highlands",
        "Holyrood",
        "Ile d\'Ambre",
        "Ilot",
        "Isidore Rose",
        "Joli Bois",
        "Jolis Bois",
        "Julien",
        "Ka Hine",
        "Khoyratty",
        "Kiurpipas",
        "L\'Agrement",
        "L\'Amitie",
        "L\'Assurance",
        "L\'Avenir",
        "L\'Embrasure",
        "L\'Escalier",
        "L\'Escalier",
        "L\'Esperance",
        "L\'Espoir",
        "L\'Etoile",
        "L\'Union",
        "L\'Unite",
        "La Baraque",
        "La Barraque",
        "La Bergerie",
        "Labonte",
        "Labourdonnais",
        "La Caroline",
        "La Caverne",
        "La Clémence",
        "La Cocoterie",
        "La Commune",
        "La Coterie",
        "La Crete",
        "La Croisee",
        "La Dagotiere",
        "La Flora",
        "La Gaiété",
        "La Gaulette",
        "Lagesse",
        "La Laura",
        "Lalmatie",
        "La Louise",
        "La Lucia",
        "La Lucie",
        "La Marie",
        "La Marre",
        "La Mecque",
        "La Mivoie",
        "La Morue",
        "La Nourrice",
        "La Rampe",
        "La Rampe - Le Moirt",
        "La Rosa",
        "La Russie",
        "La Source",
        "La Sourdine",
        "Laventure",
        "Lavilleon",
        "Le Bocage",
        "Le Bouchon",
        "Le Chaland",
        "Le Goulet",
        "Le Hochet",
        "Le Marres",
        "Le Morne",
        "Leonbourg",
        "Le Plessis",
        "Le Pétrin",
        "Le Ravin",
        "Le Réduit",
        "Les Casernes",
        "Les Guibies",
        "Les Mariannes",
        "Les Marres",
        "Les Salines",
        "Lesur",
        "Le Val",
        "Le Vallon",
        "Ligne Barrin",
        "Long Mountain",
        "Luchon",
        "Luçon",
        "L’Agrément",
        "L’Amitie",
        "L’Assurance",
        "L’Avenir",
        "L’Embrasure",
        "L’Escalier",
        "L’Escalier",
        "L’Espoir",
        "L’Espérance",
        "L’Union",
        "L’Unité",
        "L’Étoile",
        "Madame Azor",
        "Madame Cayeux",
        "Magenta",
        "Mahebourg",
        "Maison Blanche",
        "Majeburas",
        "Malherbes",
        "Mamzelle Jeanne",
        "Mapou",
        "Mare Carree",
        "Mare Chicose",
        "Mare d\'Albert",
        "Mare d\'Australia",
        "Mare Jacot",
        "Mare Jocquot",
        "Mare La Chaux",
        "Mare Saint-Amand",
        "Mare Samson",
        "Mare Tabac",
        "Marie Jeanie",
        "Medine",
        "Medine Anna",
        "Melotte",
        "Melrose",
        "Melville",
        "Mesnil",
        "Metheline",
        "Midlands",
        "Minissy",
        "Moka",
        "Moka",
        "Moka Village",
        "Mon Choisy",
        "Mon Désert",
        "Mon Désert",
        "Mon Goût",
        "Mon Loisir",
        "Mon Piton",
        "Mon Repos",
        "Mon Rocher",
        "Mon Songe",
        "Montagne Ory",
        "Mont Blanc",
        "Mont Choisy",
        "Montebello",
        "Mont Fleury",
        "Mont Longue",
        "Mont Piton",
        "Mon Tresor",
        "Mon Vallon",
        "Morcellemont Saint Andre",
        "Morne",
        "Mount",
        "Mount Choisy",
        "Mount Ory",
        "New Grove",
        "New Grove Station",
        "Notre Dame",
        "Nouvelle Découverte",
        "Nouvelle France",
        "Old Grand Port",
        "Oliva",
        "Pailles Village",
        "Palmar",
        "Pamplemousses Village",
        "Pavillon",
        "Pavillon du Grand Port",
        "Pellegrin",
        "Pereybere",
        "Petit Bel Air",
        "Petit Bois",
        "Petit Camp",
        "Petite Cabane",
        "Petite Case Noyale",
        "Petite Julie",
        "Petite Riviere Noire",
        "Petite Rosalie",
        "Petite Verger",
        "Petit Gamin",
        "Petit Paquet",
        "Petit Raffray",
        "Petit Sable",
        "Petit Verger",
        "Phoenix",
        "Piton village",
        "Plaine des Papayes",
        "Plaine Magnien",
        "Plaine Noel",
        "Plaines des Papayes",
        "Plaines des Roches",
        "Plaines Magnien",
        "Plaine Sophie",
        "Plaine Verte",
        "Plaisance",
        "Plaisance(Rose-Hill)",
        "Plein Bois",
        "Pointe aux Feuilles",
        "Pointe aux Roches",
        "Pointe aux Sables",
        "Pointe d\'Esny",
        "Pointe d’Esny",
        "Pomponnette",
        "Pont Blanc",
        "Pont Colville",
        "Pont Praslin",
        "Port Louis Town",
        "Port Souillac",
        "Poste de Flacq",
        "Poudre d’Or",
        "Profonde River",
        "Providence",
        "Quartier Militaire",
        "Quatre Bornes",
        "Quatre Cocos",
        "Quatre Soeurs",
        "Queen Victoria",
        "Quinze Cantons",
        "Rama",
        "Ravin",
        "Reduit",
        "Riambel",
        "Riche Bois",
        "Riche en Eau",
        "Richeterre",
        "Rich Fund",
        "Ripailles",
        "River des Anguilles",
        "River Dragon",
        "River Profonde",
        "River Side",
        "Riviere Baptiste",
        "Riviere du Bois",
        "Riviere Seche",
        "Rivière Créoles",
        "Rivière des Anguilles",
        "Rivière des Creoles",
        "Rivière Dragon",
        "Rivière du Rempart",
        "Robinson",
        "Roche Bois",
        "Roches Brunes",
        "Roches Noires",
        "Roche Terre",
        "Rose Belle",
        "Rose Hill",
        "Roselyn Cottage",
        "Rouge Terre",
        "Ruisseau Copeaux",
        "Ruisseau Creole",
        "Ruisseau Rose",
        "Réunion Maurel",
        "Saint-André",
        "Saint-Joseph",
        "Saint Antoine",
        "Saint Aubin",
        "Saint Avold",
        "Saint Cloud",
        "Sainte-Marie",
        "Sainte Croix",
        "Sainte Madeleine",
        "Sainte Philomène",
        "Saint Felix",
        "Saint Francois",
        "Saint Félix",
        "Saint Hilaire",
        "Saint Hubert",
        "Saint Jean",
        "Saint Julien Village",
        "Saint Martin",
        "Saint Paul",
        "Saint Pierre Village",
        "Saint Remy",
        "Salazie",
        "Savannah",
        "Savinia",
        "Schoenfeld",
        "Sebastopol",
        "Seizième Mille",
        "Senneville",
        "Solférino",
        "Solitude",
        "Souffleur",
        "Soullac",
        "Stanley",
        "St Remy",
        "Suase",
        "Sujakas",
        "Surinam",
        "Tamarin",
        "Telfair",
        "Terracine",
        "Terre Rouge",
        "The Mount",
        "The Vale",
        "Tranquebar",
        "Trianon",
        "Triolet",
        "Trois Boutiques",
        "Trois Cavernes",
        "Trois Îlots",
        "Trou aux Biches",
        "Trou Chenilles",
        "Trou d\'Eau Douce",
        "Truble",
        "Trublet",
        "Twelve Mile Post ",
        "Tyack",
        "Union Flacq",
        "Union Park",
        "Union Saint Aubin",
        "Union Vale",
        "Vacoas",
        "Valentina",
        "Valetta",
        "Vallée des Prêtres",
        "Vallée Pitot",
        "Valruche",
        "Valton",
        "Verdun",
        "Verdun Station",
        "Vieux Grand Port",
        "Ville Bague",
        "Ville d\'Apray",
        "Ville Noire",
        "Ville Valio",
        "Virginia",
        "Vuillemain",
        "Wolmar",
        "Wooten"};
            this.DESTI.Location = new System.Drawing.Point(494, 310);
            this.DESTI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DESTI.Name = "DESTI";
            this.DESTI.NomalColor = System.Drawing.Color.Black;
            this.DESTI.onHoverColor = System.Drawing.Color.Gold;
            this.DESTI.selectedIndex = 0;
            this.DESTI.Size = new System.Drawing.Size(155, 36);
            this.DESTI.TabIndex = 4;
            // 
            // ENDROITPICK
            // 
            this.ENDROITPICK.BackColor = System.Drawing.Color.Transparent;
            this.ENDROITPICK.BorderRadius = 5;
            this.ENDROITPICK.DisabledColor = System.Drawing.Color.Gray;
            this.ENDROITPICK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENDROITPICK.ForeColor = System.Drawing.Color.White;
            this.ENDROITPICK.Items = new string[] {
        "Aucun",
        "Abercrombie",
        "Albion",
        "Alma",
        "Amaury",
        "Amitie",
        "Anse Jonchee",
        "Antoinette",
        "Argy",
        "Arsenal",
        "Astroea",
        "Bagatelle",
        "Baie du Cap",
        "Baie du Tombeau",
        "Baie Mannioc",
        "Baillache",
        "Bain des Dames",
        "Balisson",
        "Bambous",
        "Bambous Virieux",
        "Bananes",
        "Barachois",
        "Barkly",
        "Bar le Duc",
        "Barlow",
        "Bassin Louloup",
        "Batimarais",
        "Baty Mare",
        "Beau-Vallon",
        "Beau Bassin",
        "Beau Bois",
        "Beau Champ",
        "Beau Fond",
        "Beau Mangue",
        "Beau Manguier",
        "Beau Plan",
        "Beau Sejour",
        "Beau Site",
        "Beau Vallon",
        "Beaux Songes",
        "Bel Air",
        "Belle-Vue",
        "Belle Etoile",
        "Belle Isle",
        "Belle Mare",
        "Belle Ombre",
        "Belle Rose",
        "Belle Terre",
        "Belle Vue",
        "Belle Vue Allendy",
        "Belle Vue Harel",
        "Belle Vue Maurel",
        "Belle Vue Pilot",
        "Bell Village",
        "Bell Village Station",
        "Belmont",
        "Bel Ombre",
        "Belvedere",
        "Bel Étang",
        "Bestel",
        "Bety",
        "Black River",
        "Bois Chéri",
        "Bois d\'Oiseau",
        "Bois Mangue",
        "Bois Marchand",
        "Bois Marchand Station",
        "Bois Pignolet",
        "Bois Pougnet",
        "Bois Rouge",
        "Bois Sec",
        "Bon Accueil",
        "Bon Air",
        "Bon Courage",
        "Bon Espoir",
        "Bon Manioc",
        "Bonne Mere",
        "Bonne Terre",
        "Bonne Veine",
        "Bort Lois",
        "Bouchon",
        "Bramsthan",
        "Bras d\'Eau",
        "Bras d’Eau",
        "Brisee Verdiere",
        "Britannia",
        "Bémanique",
        "Bénarès",
        "Cachette",
        "Calebasses",
        "Camp Accacia",
        "Camp Auguste",
        "Campbell",
        "Camp Berthaud",
        "Camp Bestel",
        "Camp Bonnemère",
        "Camp Bouillon",
        "Camp Carol",
        "Camp Cassia",
        "Camp Caval",
        "Camp Creoles",
        "Camp Créole",
        "Camp Créoles",
        "Camp de Masque",
        "Camp de Masque Pave",
        "Camp de Masque Station",
        "Camp des Embrevades",
        "Camp Diable",
        "Camp Fouquereaux",
        "Camp Garreau",
        "Camp Ithier",
        "Camp Jardin",
        "Camp La Savanne",
        "Camp Malgache",
        "Camp Mapou",
        "Camp Marcelin",
        "Camp Poorun",
        "Camp Roches",
        "Camp Sonah",
        "Camp Thorel",
        "Camp Thoret",
        "Camp Yoloff",
        "Candos",
        "Canot",
        "Cap Malheureux",
        "Caroline",
        "Carreau La Liane",
        "Carreau Lalo",
        "Cascavelle",
        "Casela",
        "Cassis",
        "Cent Gaulettes",
        "Centre de Flacq",
        "Chamarel",
        "Chamouny",
        "Champ de Mars",
        "Chantenay",
        "Chemin Grenier",
        "Choisy",
        "Chébel",
        "Cinq Arpents",
        "Circonstance",
        "Cite La Cure",
        "Cité Valijée",
        "Clarence",
        "Clarens",
        "Clavet",
        "Cluny",
        "Clémencia",
        "Congomah",
        "Constance",
        "Coquinbourg",
        "Coromandel",
        "Coteau Raffin",
        "Coteau Rafin",
        "Cote d\'Or",
        "Cottage",
        "Crève Coeur",
        "Curepipe",
        "Côte d’Or",
        "D\'Epinay",
        "Dagotière",
        "Dalais",
        "Deep River",
        "Deux Bras",
        "Deux Frères",
        "Dubreuil",
        "D’Epinay",
        "Eau Bleue",
        "Eau Bonne",
        "Eaux Coulée",
        "Ebene",
        "Ebene City",
        "Ebene CyberCity",
        "Ecroignard",
        "Eighteenth Mile Village",
        "Engrais Cathan",
        "Engrais Martial",
        "Ernest Florent",
        "Escalier",
        "Espérance Trébuchet",
        "Etoile",
        "Ferney",
        "Ferney Mill",
        "Flacq",
        "Flic-en-Flacq",
        "Flic en Flac",
        "Floreal",
        "Fond du Sac",
        "Fontenelle",
        "Forbach",
        "Forest Side",
        "Frederica",
        "Gaboola",
        "Germain",
        "Glen Park",
        "Gokoola",
        "Goodlands",
        "Grand Baie",
        "Grand Bel Air",
        "Grand Bois",
        "Grand dans Fond",
        "Grande Baie",
        "Grande Case Noyale",
        "Grande Gaube",
        "Grande Pointe aux Piments",
        "Grande Retraite",
        "Grande Retraits",
        "Grande Reviere Sud Est",
        "Grande Riviere Noire",
        "Grande Rivière Sud Est",
        "Grande Rosalie",
        "Grand Gaube",
        "Grand River",
        "Grand River North West",
        "Grand River South East",
        "Grand Rivière Noire",
        "Grand Sable",
        "Gros Billot",
        "Gros Bois",
        "Gros Cailloux",
        "Haut de Flacq",
        "Haute Rive",
        "Haut Rive",
        "Helvétia",
        "Henrietta",
        "Hermitage",
        "Hervé",
        "Highlands",
        "Holyrood",
        "Ile d\'Ambre",
        "Ilot",
        "Isidore Rose",
        "Joli Bois",
        "Jolis Bois",
        "Julien",
        "Ka Hine",
        "Khoyratty",
        "Kiurpipas",
        "L\'Agrement",
        "L\'Amitie",
        "L\'Assurance",
        "L\'Avenir",
        "L\'Embrasure",
        "L\'Escalier",
        "L\'Escalier",
        "L\'Esperance",
        "L\'Espoir",
        "L\'Etoile",
        "L\'Union",
        "L\'Unite",
        "La Baraque",
        "La Barraque",
        "La Bergerie",
        "Labonte",
        "Labourdonnais",
        "La Caroline",
        "La Caverne",
        "La Clémence",
        "La Cocoterie",
        "La Commune",
        "La Coterie",
        "La Crete",
        "La Croisee",
        "La Dagotiere",
        "La Flora",
        "La Gaiété",
        "La Gaulette",
        "Lagesse",
        "La Laura",
        "Lalmatie",
        "La Louise",
        "La Lucia",
        "La Lucie",
        "La Marie",
        "La Marre",
        "La Mecque",
        "La Mivoie",
        "La Morue",
        "La Nourrice",
        "La Rampe",
        "La Rampe - Le Moirt",
        "La Rosa",
        "La Russie",
        "La Source",
        "La Sourdine",
        "Laventure",
        "Lavilleon",
        "Le Bocage",
        "Le Bouchon",
        "Le Chaland",
        "Le Goulet",
        "Le Hochet",
        "Le Marres",
        "Le Morne",
        "Leonbourg",
        "Le Plessis",
        "Le Pétrin",
        "Le Ravin",
        "Le Réduit",
        "Les Casernes",
        "Les Guibies",
        "Les Mariannes",
        "Les Marres",
        "Les Salines",
        "Lesur",
        "Le Val",
        "Le Vallon",
        "Ligne Barrin",
        "Long Mountain",
        "Luchon",
        "Luçon",
        "L’Agrément",
        "L’Amitie",
        "L’Assurance",
        "L’Avenir",
        "L’Embrasure",
        "L’Escalier",
        "L’Escalier",
        "L’Espoir",
        "L’Espérance",
        "L’Union",
        "L’Unité",
        "L’Étoile",
        "Madame Azor",
        "Madame Cayeux",
        "Magenta",
        "Mahebourg",
        "Maison Blanche",
        "Majeburas",
        "Malherbes",
        "Mamzelle Jeanne",
        "Mapou",
        "Mare Carree",
        "Mare Chicose",
        "Mare d\'Albert",
        "Mare d\'Australia",
        "Mare Jacot",
        "Mare Jocquot",
        "Mare La Chaux",
        "Mare Saint-Amand",
        "Mare Samson",
        "Mare Tabac",
        "Marie Jeanie",
        "Medine",
        "Medine Anna",
        "Melotte",
        "Melrose",
        "Melville",
        "Mesnil",
        "Metheline",
        "Midlands",
        "Minissy",
        "Moka",
        "Moka",
        "Moka Village",
        "Mon Choisy",
        "Mon Désert",
        "Mon Désert",
        "Mon Goût",
        "Mon Loisir",
        "Mon Piton",
        "Mon Repos",
        "Mon Rocher",
        "Mon Songe",
        "Montagne Ory",
        "Mont Blanc",
        "Mont Choisy",
        "Montebello",
        "Mont Fleury",
        "Mont Longue",
        "Mont Piton",
        "Mon Tresor",
        "Mon Vallon",
        "Morcellemont Saint Andre",
        "Morne",
        "Mount",
        "Mount Choisy",
        "Mount Ory",
        "New Grove",
        "New Grove Station",
        "Notre Dame",
        "Nouvelle Découverte",
        "Nouvelle France",
        "Old Grand Port",
        "Oliva",
        "Pailles Village",
        "Palmar",
        "Pamplemousses Village",
        "Pavillon",
        "Pavillon du Grand Port",
        "Pellegrin",
        "Pereybere",
        "Petit Bel Air",
        "Petit Bois",
        "Petit Camp",
        "Petite Cabane",
        "Petite Case Noyale",
        "Petite Julie",
        "Petite Riviere Noire",
        "Petite Rosalie",
        "Petite Verger",
        "Petit Gamin",
        "Petit Paquet",
        "Petit Raffray",
        "Petit Sable",
        "Petit Verger",
        "Phoenix",
        "Piton village",
        "Plaine des Papayes",
        "Plaine Magnien",
        "Plaine Noel",
        "Plaines des Papayes",
        "Plaines des Roches",
        "Plaines Magnien",
        "Plaine Sophie",
        "Plaine Verte",
        "Plaisance",
        "Plaisance(Rose-Hill)",
        "Plein Bois",
        "Pointe aux Feuilles",
        "Pointe aux Roches",
        "Pointe aux Sables",
        "Pointe d\'Esny",
        "Pointe d’Esny",
        "Pomponnette",
        "Pont Blanc",
        "Pont Colville",
        "Pont Praslin",
        "Port Louis Town",
        "Port Souillac",
        "Poste de Flacq",
        "Poudre d’Or",
        "Profonde River",
        "Providence",
        "Quartier Militaire",
        "Quatre Bornes",
        "Quatre Cocos",
        "Quatre Soeurs",
        "Queen Victoria",
        "Quinze Cantons",
        "Rama",
        "Ravin",
        "Reduit",
        "Riambel",
        "Riche Bois",
        "Riche en Eau",
        "Richeterre",
        "Rich Fund",
        "Ripailles",
        "River des Anguilles",
        "River Dragon",
        "River Profonde",
        "River Side",
        "Riviere Baptiste",
        "Riviere du Bois",
        "Riviere Seche",
        "Rivière Créoles",
        "Rivière des Anguilles",
        "Rivière des Creoles",
        "Rivière Dragon",
        "Rivière du Rempart",
        "Robinson",
        "Roche Bois",
        "Roches Brunes",
        "Roches Noires",
        "Roche Terre",
        "Rose Belle",
        "Rose Hill",
        "Roselyn Cottage",
        "Rouge Terre",
        "Ruisseau Copeaux",
        "Ruisseau Creole",
        "Ruisseau Rose",
        "Réunion Maurel",
        "Saint-André",
        "Saint-Joseph",
        "Saint Antoine",
        "Saint Aubin",
        "Saint Avold",
        "Saint Cloud",
        "Sainte-Marie",
        "Sainte Croix",
        "Sainte Madeleine",
        "Sainte Philomène",
        "Saint Felix",
        "Saint Francois",
        "Saint Félix",
        "Saint Hilaire",
        "Saint Hubert",
        "Saint Jean",
        "Saint Julien Village",
        "Saint Martin",
        "Saint Paul",
        "Saint Pierre Village",
        "Saint Remy",
        "Salazie",
        "Savannah",
        "Savinia",
        "Schoenfeld",
        "Sebastopol",
        "Seizième Mille",
        "Senneville",
        "Solférino",
        "Solitude",
        "Souffleur",
        "Soullac",
        "Stanley",
        "St Remy",
        "Suase",
        "Sujakas",
        "Surinam",
        "Tamarin",
        "Telfair",
        "Terracine",
        "Terre Rouge",
        "The Mount",
        "The Vale",
        "Tranquebar",
        "Trianon",
        "Triolet",
        "Trois Boutiques",
        "Trois Cavernes",
        "Trois Îlots",
        "Trou aux Biches",
        "Trou Chenilles",
        "Trou d\'Eau Douce",
        "Truble",
        "Trublet",
        "Twelve Mile Post ",
        "Tyack",
        "Union Flacq",
        "Union Park",
        "Union Saint Aubin",
        "Union Vale",
        "Vacoas",
        "Valentina",
        "Valetta",
        "Vallée des Prêtres",
        "Vallée Pitot",
        "Valruche",
        "Valton",
        "Verdun",
        "Verdun Station",
        "Vieux Grand Port",
        "Ville Bague",
        "Ville d\'Apray",
        "Ville Noire",
        "Ville Valio",
        "Virginia",
        "Vuillemain",
        "Wolmar",
        "Wooten"};
            this.ENDROITPICK.Location = new System.Drawing.Point(494, 207);
            this.ENDROITPICK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ENDROITPICK.Name = "ENDROITPICK";
            this.ENDROITPICK.NomalColor = System.Drawing.Color.Black;
            this.ENDROITPICK.onHoverColor = System.Drawing.Color.Gold;
            this.ENDROITPICK.selectedIndex = 0;
            this.ENDROITPICK.Size = new System.Drawing.Size(155, 36);
            this.ENDROITPICK.TabIndex = 3;
            // 
            // IDMat
            // 
            this.IDMat.BorderColorFocused = System.Drawing.Color.Gold;
            this.IDMat.BorderColorIdle = System.Drawing.Color.Black;
            this.IDMat.BorderColorMouseHover = System.Drawing.Color.Black;
            this.IDMat.BorderThickness = 3;
            this.IDMat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDMat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.IDMat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IDMat.isPassword = false;
            this.IDMat.Location = new System.Drawing.Point(252, 207);
            this.IDMat.Margin = new System.Windows.Forms.Padding(4);
            this.IDMat.Name = "IDMat";
            this.IDMat.Size = new System.Drawing.Size(127, 36);
            this.IDMat.TabIndex = 0;
            this.IDMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // IDClient
            // 
            this.IDClient.BorderColorFocused = System.Drawing.Color.Gold;
            this.IDClient.BorderColorIdle = System.Drawing.Color.Black;
            this.IDClient.BorderColorMouseHover = System.Drawing.Color.Black;
            this.IDClient.BorderThickness = 3;
            this.IDClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDClient.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.IDClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IDClient.isPassword = false;
            this.IDClient.Location = new System.Drawing.Point(252, 337);
            this.IDClient.Margin = new System.Windows.Forms.Padding(4);
            this.IDClient.Name = "IDClient";
            this.IDClient.Size = new System.Drawing.Size(66, 36);
            this.IDClient.TabIndex = 2;
            this.IDClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // IDChaffeur
            // 
            this.IDChaffeur.BorderColorFocused = System.Drawing.Color.Gold;
            this.IDChaffeur.BorderColorIdle = System.Drawing.Color.Black;
            this.IDChaffeur.BorderColorMouseHover = System.Drawing.Color.Black;
            this.IDChaffeur.BorderThickness = 3;
            this.IDChaffeur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDChaffeur.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.IDChaffeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IDChaffeur.isPassword = false;
            this.IDChaffeur.Location = new System.Drawing.Point(252, 272);
            this.IDChaffeur.Margin = new System.Windows.Forms.Padding(4);
            this.IDChaffeur.Name = "IDChaffeur";
            this.IDChaffeur.Size = new System.Drawing.Size(66, 36);
            this.IDChaffeur.TabIndex = 1;
            this.IDChaffeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IDChaffeur.OnValueChanged += new System.EventHandler(this.IDChaffeur_OnValueChanged);
            // 
            // lblreserv
            // 
            this.lblreserv.AutoSize = true;
            this.lblreserv.BackColor = System.Drawing.SystemColors.Control;
            this.lblreserv.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblreserv.Location = new System.Drawing.Point(61, 18);
            this.lblreserv.Name = "lblreserv";
            this.lblreserv.Size = new System.Drawing.Size(257, 25);
            this.lblreserv.TabIndex = 28;
            this.lblreserv.Text = "FAIRE UNE RÉSERVATION";
            // 
            // HeureReser
            // 
            this.HeureReser.AutoSize = true;
            this.HeureReser.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic);
            this.HeureReser.Location = new System.Drawing.Point(313, 421);
            this.HeureReser.Name = "HeureReser";
            this.HeureReser.Size = new System.Drawing.Size(66, 22);
            this.HeureReser.TabIndex = 46;
            this.HeureReser.Text = "HEURE :";
            // 
            // HeurePick
            // 
            this.HeurePick.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HeurePick.Location = new System.Drawing.Point(404, 423);
            this.HeurePick.MaxDate = new System.DateTime(2222, 5, 1, 0, 0, 0, 0);
            this.HeurePick.MinDate = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
            this.HeurePick.Name = "HeurePick";
            this.HeurePick.Size = new System.Drawing.Size(82, 20);
            this.HeurePick.TabIndex = 5;
            this.HeurePick.Value = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
            this.HeurePick.ValueChanged += new System.EventHandler(this.HeurePick_ValueChanged);
            // 
            // btnsave
            // 
            this.btnsave.ActiveBorderThickness = 1;
            this.btnsave.ActiveCornerRadius = 20;
            this.btnsave.ActiveFillColor = System.Drawing.Color.IndianRed;
            this.btnsave.ActiveForecolor = System.Drawing.Color.White;
            this.btnsave.ActiveLineColor = System.Drawing.Color.IndianRed;
            this.btnsave.BackColor = System.Drawing.SystemColors.Control;
            this.btnsave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsave.BackgroundImage")));
            this.btnsave.ButtonText = "SAUVEGARDER";
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnsave.IdleBorderThickness = 1;
            this.btnsave.IdleCornerRadius = 20;
            this.btnsave.IdleFillColor = System.Drawing.Color.Black;
            this.btnsave.IdleForecolor = System.Drawing.Color.Honeydew;
            this.btnsave.IdleLineColor = System.Drawing.Color.Black;
            this.btnsave.Location = new System.Drawing.Point(397, 498);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(169, 37);
            this.btnsave.TabIndex = 6;
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveBorderThickness = 1;
            this.btnEdit.ActiveCornerRadius = 20;
            this.btnEdit.ActiveFillColor = System.Drawing.Color.IndianRed;
            this.btnEdit.ActiveForecolor = System.Drawing.Color.White;
            this.btnEdit.ActiveLineColor = System.Drawing.Color.IndianRed;
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.ButtonText = "NOUVEAU";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.IdleBorderThickness = 1;
            this.btnEdit.IdleCornerRadius = 20;
            this.btnEdit.IdleFillColor = System.Drawing.Color.Black;
            this.btnEdit.IdleForecolor = System.Drawing.Color.Honeydew;
            this.btnEdit.IdleLineColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(213, 498);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(169, 37);
            this.btnEdit.TabIndex = 60;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // DBstate2
            // 
            this.DBstate2.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_database_information_1034692;
            this.DBstate2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DBstate2.Location = new System.Drawing.Point(768, 10);
            this.DBstate2.Name = "DBstate2";
            this.DBstate2.Size = new System.Drawing.Size(42, 38);
            this.DBstate2.TabIndex = 58;
            this.DBstate2.TabStop = false;
            this.DBstate2.Visible = false;
            // 
            // DBstate1
            // 
            this.DBstate1.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_database_security_1034722;
            this.DBstate1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DBstate1.Location = new System.Drawing.Point(768, 10);
            this.DBstate1.Name = "DBstate1";
            this.DBstate1.Size = new System.Drawing.Size(42, 38);
            this.DBstate1.TabIndex = 57;
            this.DBstate1.TabStop = false;
            this.DBstate1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_Rainbow_2998142;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(202, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_business_office_seo_finance_work_coffee_pause_management_10_29871411;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // pbarrow
            // 
            this.pbarrow.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_arrowdown_1167964;
            this.pbarrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbarrow.Location = new System.Drawing.Point(513, 249);
            this.pbarrow.Name = "pbarrow";
            this.pbarrow.Size = new System.Drawing.Size(100, 50);
            this.pbarrow.TabIndex = 35;
            this.pbarrow.TabStop = false;
            // 
            // ploc
            // 
            this.ploc.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_basics_23_2968111;
            this.ploc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ploc.Location = new System.Drawing.Point(494, 60);
            this.ploc.Name = "ploc";
            this.ploc.Size = new System.Drawing.Size(138, 127);
            this.ploc.TabIndex = 34;
            this.ploc.TabStop = false;
            // 
            // btnsettings
            // 
            this.btnsettings.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_Streamline_75_185095;
            this.btnsettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Location = new System.Drawing.Point(769, 58);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(42, 37);
            this.btnsettings.TabIndex = 64;
            this.btnsettings.Text = " ";
            this.btnsettings.UseVisualStyleBackColor = true;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_063_Undo_183192;
            this.btnreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnreset.FlatAppearance.BorderSize = 0;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Location = new System.Drawing.Point(771, 521);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(38, 30);
            this.btnreset.TabIndex = 67;
            this.btnreset.Text = " ";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnhelp
            // 
            this.btnhelp.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_help_172477;
            this.btnhelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnhelp.FlatAppearance.BorderSize = 0;
            this.btnhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhelp.Location = new System.Drawing.Point(771, 99);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(38, 30);
            this.btnhelp.TabIndex = 68;
            this.btnhelp.Text = " ";
            this.btnhelp.UseVisualStyleBackColor = true;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // error1
            // 
            this.error1.AutoSize = true;
            this.error1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error1.ForeColor = System.Drawing.Color.LightCoral;
            this.error1.Location = new System.Drawing.Point(387, 196);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(16, 20);
            this.error1.TabIndex = 69;
            this.error1.Text = "*";
            this.error1.Visible = false;
            // 
            // error2
            // 
            this.error2.AutoSize = true;
            this.error2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error2.ForeColor = System.Drawing.Color.LightCoral;
            this.error2.Location = new System.Drawing.Point(325, 264);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(16, 20);
            this.error2.TabIndex = 70;
            this.error2.Text = "*";
            this.error2.Visible = false;
            // 
            // error3
            // 
            this.error3.AutoSize = true;
            this.error3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error3.ForeColor = System.Drawing.Color.LightCoral;
            this.error3.Location = new System.Drawing.Point(323, 328);
            this.error3.Name = "error3";
            this.error3.Size = new System.Drawing.Size(16, 20);
            this.error3.TabIndex = 71;
            this.error3.Text = "*";
            this.error3.Visible = false;
            // 
            // error4
            // 
            this.error4.AutoSize = true;
            this.error4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error4.ForeColor = System.Drawing.Color.LightCoral;
            this.error4.Location = new System.Drawing.Point(656, 196);
            this.error4.Name = "error4";
            this.error4.Size = new System.Drawing.Size(16, 20);
            this.error4.TabIndex = 72;
            this.error4.Text = "*";
            this.error4.Visible = false;
            // 
            // error5
            // 
            this.error5.AutoSize = true;
            this.error5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error5.ForeColor = System.Drawing.Color.LightCoral;
            this.error5.Location = new System.Drawing.Point(656, 299);
            this.error5.Name = "error5";
            this.error5.Size = new System.Drawing.Size(16, 20);
            this.error5.TabIndex = 73;
            this.error5.Text = "*";
            this.error5.Visible = false;
            // 
            // error6
            // 
            this.error6.AutoSize = true;
            this.error6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error6.ForeColor = System.Drawing.Color.LightCoral;
            this.error6.Location = new System.Drawing.Point(492, 404);
            this.error6.Name = "error6";
            this.error6.Size = new System.Drawing.Size(16, 20);
            this.error6.TabIndex = 74;
            this.error6.Text = "*";
            this.error6.Visible = false;
            // 
            // Res
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.error6);
            this.Controls.Add(this.error5);
            this.Controls.Add(this.error4);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.error3);
            this.Controls.Add(this.error2);
            this.Controls.Add(this.error1);
            this.Controls.Add(this.btnhelp);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsettings);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.DBstate2);
            this.Controls.Add(this.DBstate1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.HeurePick);
            this.Controls.Add(this.HeureReser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTO);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.pbarrow);
            this.Controls.Add(this.ploc);
            this.Controls.Add(this.DESTI);
            this.Controls.Add(this.ENDROITPICK);
            this.Controls.Add(this.IDMat);
            this.Controls.Add(this.IDClient);
            this.Controls.Add(this.IDChaffeur);
            this.Controls.Add(this.lblreserv);
            this.Name = "Res";
            this.Size = new System.Drawing.Size(825, 562);
            this.Load += new System.EventHandler(this.Res_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBstate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBstate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbarrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ploc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btnsave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTO;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.PictureBox pbarrow;
        private System.Windows.Forms.PictureBox ploc;
        private Bunifu.Framework.UI.BunifuDropdown DESTI;
        private Bunifu.Framework.UI.BunifuDropdown ENDROITPICK;
        private Bunifu.Framework.UI.BunifuMetroTextbox IDMat;
        private Bunifu.Framework.UI.BunifuMetroTextbox IDClient;
        private Bunifu.Framework.UI.BunifuMetroTextbox IDChaffeur;
        private System.Windows.Forms.Label lblreserv;
        private System.Windows.Forms.Label HeureReser;
        private System.Windows.Forms.DateTimePicker HeurePick;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox DBstate2;
        private System.Windows.Forms.PictureBox DBstate1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEdit;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnhelp;
        private System.Windows.Forms.Label error1;
        private System.Windows.Forms.Label error2;
        private System.Windows.Forms.Label error3;
        private System.Windows.Forms.Label error4;
        private System.Windows.Forms.Label error5;
        private System.Windows.Forms.Label error6;
    }
}
