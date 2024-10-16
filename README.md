# Git Actions for Unity
*Automate Unity Builds with Ease*

![Promo Image](Promo/bender.png)

**Description:**  
Git Actions for Unity automates your Unity build process with GitHub Actions, simplifying setup and enhancing developer productivity.
<BR>
## 🚀 Quick Setup
Easily integrate GitHub Actions into your Unity project with these simple steps:

1. **Download** [the latest release](/releases) and copy the `.github` folder to your project root.
2. **Run** the [activation file workflow 🔑](/.github/workflows/acuire-unity-activation-file.yml), then download and unzip the artifact to retrieve your `.alf` file.
3. **Visit** the [Unity License Portal](https://license.unity3d.com/manual) and upload your `.alf` file to obtain the `.ulf` file.
4. **Create a secret** in your repository settings: Navigate to **Secrets > Actions**, and create a secret named `UNITY_LICENSE`.
5. **Paste** the contents of your `.ulf` file into the `UNITY_LICENSE` secret.
6. **Trigger** the [Build Project 🏗️](/.github/workflows/main.yml) workflow by pushing to the `main` branch.

> **Note:**  
> For GitHub Pages, ensure your repo is public. Navigate to **Repo Settings > Pages**, set **Source** to `Deploy from a branch`, and select the `gh-pages` branch.  
> Your page will be published at: [https://`Repo-Owner`.github.io/`Repo-Name`](https://muammar-yacoob.github.io/Unity-GitActions)

## 🔔 Notifications Setup
Stay updated with automated notifications by setting up webhooks:

### 1. Create a Webhook
- **Discord:** Go to Server Settings > Integrations > Webhooks > New Webhook > Choose the desired Channel.
- **MS Teams:** In your [Channel], click on ... > Connectors > Incoming Webhook > Configure.
- **Slack:** Navigate to [Workspace] > Administration > Manage apps > Custom Integrations > Incoming WebHooks.

### 2. GitHub Settings
In your GitHub Repo Settings:
- Go to Secrets > Actions > New repository secret.
- Use the following names based on your chosen platform:
  - `DISCORD_WEBHOOK`
  - `MS_TEAMS_WEBHOOK`
  - `SLACK_WEBHOOK`
- Paste the corresponding webhook URL as the value.

## 📊 UML Diagrams Generation
The project includes an automated workflow for generating UML diagrams.

### Usage
Simply modify `.puml` files in the `docs/diagrams` directory to trigger UML diagram generation. PNGs will match the names of the `.puml` files.

### Embed UML in Markdown
You can embed UML diagrams in your Markdown using the following syntax:
```markdown
![StageSystem Class Diagram](./docs/diagrams/StageSystem.png)
```


## Acknowledgments
The project is using the following services:
- [PlantUML project](http://plantuml.com): Licensed under [GPL](http://www.gnu.org/copyleft/gpl.html).
- [PlantUmlClassDiagramGenerator](https://github.com/pierre3/PlantUmlClassDiagramGenerator) by pierre3: Licensed under [MIT](https://github.com/pierre3/PlantUmlClassDiagramGenerator/blob/master/LICENSE).
- [PlantUML URL generator project](https://gitlab.com/iternity/plantuml.cs) by iTernity GmbH: Licensed under [MIT](https://gitlab.com/iternity/plantuml.cs/blob/master/LICENSE).
