// See https://aka.ms/new-console-template for more information
using PracticeWithcSharp.Models;

List<Beer> listBeers = new() {
    new Beer {
        Name = "Leon",
        Brand = "Modelo",
        AlcoholGrade = "15%",
        Size = "grande",
        CountryOrigin = "Mexico"
    },
    new Beer {
        Name = "Indio",
        Brand = "Moctezuma",
        AlcoholGrade = "7,8%",
        Size = "grande",
        CountryOrigin = "Mexico"
    },
    new Beer {
        Name = "Tecate",
        Brand = "Moctezuma",
        AlcoholGrade = "17%",
        Size = "grande",
        CountryOrigin = "Mexico"
    },
    new Beer {
        Name = "Victoria",
        Brand = "Modelo",
        AlcoholGrade = "4,5%",
        Size = "laton",
        CountryOrigin = "Mexico"
    },
    new Beer {
        Name = "Negra Modelo",
        Brand = "Modelo",
        AlcoholGrade = "4,7%",
        Size = "laton",
        CountryOrigin = "Mexico"
    },
    new Beer {
        Name = "Heineken",
        Brand = "Heineken International",
        AlcoholGrade = "5,7%",
        Size = "laton",
        CountryOrigin = "Paises bajos"
    },
    new Beer {
        Name = "Modelo Especial",
        Brand = "Modelo",
        AlcoholGrade = "4,5%",
        Size = "laton",
        CountryOrigin = "Mexico"
    },
    new Beer {
        Name = "Gallo",
        Brand = "Guatemaltecos locos",
        AlcoholGrade = "5,2%",
        Size = "laton",
        CountryOrigin = "Guatemala"
    }
};
listBeers.ForEach(beer => Console.WriteLine($"{beer.Name} de {beer.Brand} con {beer.AlcoholGrade} grados de alcohol, presentacion {beer.Size} y su pais de origen {beer.CountryOrigin}."));