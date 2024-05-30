using AIStudio.Components.Blocks;

using Microsoft.AspNetCore.Components;

namespace AIStudio.Components.Pages;

public partial class Home : ComponentBase
{
    private static readonly TextItem[] ITEMS_ADVANTAGES =
    [
        new TextItem("Free of charge", "The app is free to use, both for personal and commercial purposes."),
        new TextItem("Independence", "Users are not tied to any single provider. The initial version supports OpenAI models (like GPT-4o, GPT-4, GPT-4 Turbo, etc.). Future versions will support other providers such as Mistral or Google Gemini."),
        new TextItem("Unrestricted usage", "Unlike services like ChatGPT, which impose limits after intensive use, MindWork AI Studio offers unlimited usage through the providers API."),
        new TextItem("Cost-effective", "You only pay for what you use, which can be cheaper than monthly subscription services like ChatGPT Plus, especially if used infrequently. But beware, here be dragons: For extremely intensive usage, the API costs can be significantly higher. Unfortunately, providers currently do not offer a way to display current costs in the app. Therefore, check your account with the respective provider to see how your costs are developing. When available, use prepaid and set a cost limit."),
        new TextItem("Privacy", "The data entered into the app is not used for training by the providers since we are using the provider's API."),
        new TextItem("Flexibility", "Choose the provider and model best suited for your current task."),
        new TextItem("No bloatware", "The app requires minimal storage for installation and operates with low memory usage. Additionally, it has a minimal impact on system resources, which is beneficial for battery life."),
    ];

    private static readonly TextItem[] ITEMS_VISION =
    [
        new TextItem("Meet your needs", "Whatever your job or task is, MindWork AI Studio aims to meet your needs: whether you're a project manager, scientist, artist, author, software developer, or game developer."),
        new TextItem("One stop shop", "The app will strive to fulfill all your AI needs: text-generation AI (LLM), image-generation AI, audio-generation AI (text-to-speech, potentially even text-to-music), and audio input (transcription, dictation). When there's a provider and an API available, we'll try to integrate it."),
        new TextItem("Local file system", "When you wish, we aim to integrate your local system. Local documents could be incorporated using Retrieval-Augmented Generation (RAG), and we could directly save AI-generated content to your file system."),
        new TextItem("Local AI systems", "Want to use AI systems locally and offline? We aim to make that possible too."),
        new TextItem("Your AI systems", "Prefer to run your AI systems with providers like replicate.com? We plan to support that!"),
        new TextItem("Assistants", "We aim to integrate specialized user interfaces as assistants. For example, a UI specifically for writing emails, or one designed for translating and correcting text, and more."),
    ];

    private const string QUICK_START_GUIDE =
        """
        Ready to dive in and get started with MindWork AI Studio? This quick start guide will help you set up everything you need to start using the app.
        
        ## Step 1: Create an Account with OpenAI
        1. Go to [OpenAI's platform](https://platform.openai.com/).
        2. Click on "Sign up" and follow the instructions provided.
        
        ## Step 2: Obtain an API Key
        1. After creating your OpenAI account, ensure you have a project named "default".
        2. If you want, you can create a new project by clicking "Create project".
        3. Navigate to a project of your choice, then click on "API keys" in the left-hand navigation menu.
        4. You might need to validate your phone number. Click "Start verification" and follow the instructions.
        5. Once verified, click "Create new secret key" to generate a new API key for the selected project.
        6. Name your key something descriptive like "AI Studio Laptop."
        7. Copy the displayed secret key. Remember, you will not be able to see this key again.
        8. Store it in a password manager like [KeePassXC](https://keepassxc.org).
        9. **Important:** Treat your API key like a secret password. Anyone with access to your key can use OpenAI's systems **at your expense**. **Do not share it with anyone!**
        
        ## Step 3: Add OpenAI as a Provider in MindWork AI Studio
        1. Go to the settings section in MindWork AI Studio.
        2. Click "Add Provider" and select OpenAI as the provider.
        3. Paste your API key into the corresponding field.
        
        ## Step 4: Load OpenAI Models
        1. Ensure you have an internet connection and your API key is valid.
        2. Click "Reload" to retrieve a list of available OpenAI models.
        3. Select "gpt-4o" to use the latest model.
        4. Provide a name for this combination of provider, API key, and model. This is called the "instance name". For example, you can name it based on the usage context, such as "Personal OpenAI" or "Work OpenAI".
        
        ## Step 5: Save the Provider
        1. Click "Add" to save the provider.
        2. Depending on your operating system and settings, you may need to enter your login password. This is required to store and access your API key securely.
        
        ## Step 6: Add Funds to Your OpenAI Account
        To utilize OpenAI's services, you need to add funds to your account. It's best to use the prepaid method to avoid high bills and set your budget. Navigate to the "Billing" section. Here, you can see your current balance. Click on "Add to credit balance" to deposit an amount. A balance of $10 is sufficient to start.
        
        ## Step 7: Start Chatting with the AI
        1. Switch to the chat section in MindWork AI Studio.
        2. Select your provider from the dropdown menu at the top.
        3. Enter your question or message in the input field below to start your first chat with the AI.
        
        ## Additional Resources
        There are also video tutorials on how to obtain your OpenAI API key. One example is this video by Anders Jensen: [https://www.youtube.com/watch?v=OB99E7Y1cMA](https://www.youtube.com/watch?v=OB99E7Y1cMA).
        
        That's it! You're ready to explore and create with MindWork AI Studio. Enjoy your journey!                               
        """;
}