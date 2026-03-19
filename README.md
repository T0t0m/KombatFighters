# 🃏 Kombat Fighters Creator

**Lien du site** : <https://t0t0m.github.io/KombatFighters/>

**Kombat Fighters Creator** est une application web Single-Page (SPA) permettant de concevoir, personnaliser et générer des paquets de cartes pour un jeu de combat sur table.
L'application est pensée pour le format **"Print & Play"** : créez vos cartes dans le navigateur et téléchargez un document PDF prêt à être imprimé et découpé.

## ✨ Fonctionnalités Principales

* **Gestion par Familles** : Regroupez vos cartes par familles. Définissez un verso commun et une couleur de fond globale pour la famille.

* **Éditeur d'Attaques** : Chaque carte représente une attaque spécifique. Vous pouvez lui attribuer un nom et une image d'illustration.

* **Grille de Combat Interactive** : Chaque carte possède une matrice 3x3 interactive. Cliquez sur les cases pour définir visuellement la zone d'effet de l'attaque.

* **Export PDF Haute Précision** : Génération d'un fichier PDF (format A4) contenant vos cartes alignées à l'échelle standard (63 x 88 mm), idéal pour les pochettes de protection (sleeves).

* **100% Client-Side** : Aucune base de données ni serveur requis. Toutes les opérations (y compris la génération du PDF) se font directement dans le navigateur de l'utilisateur pour une confidentialité et une rapidité maximales.

## 🛠️ Technologies Utilisées

* **Framework** : [Blazor WebAssembly (Autonome)](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor) - .NET 8

* **Langages** : C#, HTML, CSS

* **Génération PDF** : [QuestPDF](https://www.questpdf.com/) (Génération de documents au millimètre près en pur C#)

* **Hébergement cible** : GitHub Pages (Hébergement statique)

## 🚀 Installation et Lancement (Développement)

### Prérequis

* [Visual Studio 2026](https://visualstudio.microsoft.com/fr/) (avec la charge de travail "Développement web et ASP.NET")

* Le SDK .NET 8.0.

### Démarrer le projet

1. Clonez ce dépôt sur votre machine locale.

2. Ouvrez le fichier `.sln` avec Visual Studio.

3. Appuyez sur le bouton **Play (Débogage HTTP/HTTPS)** en haut de l'écran ou appuyez sur `F5`.

4. Une fenêtre de terminal (Kestrel) s'ouvrira, suivie de votre navigateur web affichant l'application.

## 📦 Déploiement

Ce projet est une application WebAssembly autonome. Il produit des fichiers statiques lors de la publication.

**Pour publier sur GitHub Pages** :
Le déploiement est géré via un workflow GitHub Actions. Il faut prêter attention à un détail majeur pour que l'application Blazor fonctionne correctement sur une sous-URL :

* L'adaptation de la balise `<base href="/KombatFighters/" />` dans le fichier `index.html` (ou via le script de déploiement) pour correspondre au chemin de votre dépôt.