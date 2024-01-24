# RecetteAPI
Recette API est une API conçue pour alimenter une application mobile dédiée à la gestion des recettes culinaires. Cette API offre des fonctionnalités complètes de CRUD (Create, Read, Update, Delete) pour permettre aux utilisateurs de consulter des recettes triées par catégories, ainsi que de visualiser les détails des ingrédients pendant que l'administrateur connecté peut créer, modifier et supprimer les catégories, recettes et ingrédients.

## Fonctionnalités principales
Consulter des Recettes par Catégories : Les utilisateurs peuvent parcourir et filtrer les recettes en fonction de différentes catégories pour trouver rapidement celles qui correspondent à leurs préférences.

Détails des Ingrédients : Chaque recette affiche une liste détaillée des ingrédients nécessaires, offrant une vue complète sur la composition des plats.

Gestion Administrateur : Les administrateurs connectés ont la possibilité d'ajouter, de modifier ou de supprimer des catégories, des recettes et des ingrédients pour maintenir une base de données dynamique et à jour.

## Technologies employées
-NET 8.0 et ASP.NET Core Web AP
-Docker et PostGre

## Installation de Docker et Liaison avec PostgreSQL
RecetteAPI utilise Docker pour faciliter le déploiement et la gestion de PostgreSQL, la base de données sous-jacente. Suivez ces étapes pour installer Docker et configurer PostgreSQL avec RecetteAPI.

### Installation de Docker
-Si Docker n'est pas encore installé sur votre machine, sur macOS ou Windows, téléchargez et installez Docker Desktop depuis le site officiel :
https://www.docker.com/products/docker-desktop/

-lancer docker desktop

### Exécution de PostgreSQL avec Docker
#### prérequis: avoir le fichier .env à la racine du projet
pour créer l'image à partir de la définition paramétrée dans le dockerfile, lancer la commande suivante dans le terminal:
```Terminal
docker build -t postgres .
```
Le point est important

puis, toujours dans le temrinal
## (attention ne pas copier ce code tel quel)
```Terminal
docker run --name recette-api-db -p 5433:5432 -e POSTGRES_USER=POSTGRES_USER -e POSTGRES_PASSWORD=POSTGRES_PASSWORD -e POSTGRES_DB=POSTGRES_DB -d postgres
```
concernant POSTGRES_USER, POSTGRES_PASSWORD et POSTGRES_DB
remplacer le cotenu des données par les variables d'environnement du même nom

le détail de cette commande est le suivant:
--name recette-api-db: Donne un nom spécifique à l'instance de la base de données (ici, "recette-api-db").
-p 5433:5432: Mappe le port 5432 (port par défaut pour PostgreSQL) de la base de données dans le conteneur sur le port 5433 de l'hôte.
-e POSTGRES_USER: Définit le nom d'utilisateur de PostgreSQL
-e POSTGRES_PASSWORD: Définit le mot de passe de l'utilisateur PostgreSQL.
-e POSTGRES_DB: Crée une base de données

Le résultat devrait être le suivant dans docker desktop:
![plot](/img/docker_image.png)
![plot](/img/docker_conteneur.png)

### Vérifier que l'installation a été effectuée avec succès
Installer Bbeaver:
https://dbeaver.io/download/
La version community est suffisante

Une fois DBeaver installé et lancé, cliquer sur nouvelle connexion en haut à gauche.
![plot](/img/beaver_nouvelle_connexion.png)
Remplir les champs suivants:
port
database
nom d'utilisateur
mot de passe
![plot](/img/test_beaver_1.png)

puis cliquer sur test de la connexion, si il n'y a pas de message d'erreur, c'est que l'installation a été effectuée avec succès. Puis une fois validé on peut voir la base de données

![plot](/img/beaver.png)



