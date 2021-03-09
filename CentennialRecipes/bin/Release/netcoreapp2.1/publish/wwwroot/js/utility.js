var slideIndex = 1;
var carouselPaused = false;
var backgroundImages = [
    "../images/bg-sign-up.jpg",
    "../images/bg-recipes.jpg",
    "../images/bg-chefs.jpg",
    "../images/bg-add-recipe.jpg"];

// hides account dropdown when anywhere outside of the dropdown icon is clicked
window.onclick = function (event) {
    if (!event.target.matches('.accountDropdownIcon') &&
        !event.target.matches('.accountBtn')) {
        var accountDropdown = document.getElementById("accountDropdown");
        if (accountDropdown !== null) {
            accountDropdown.style.display = 'none';
            document.getElementsByClassName("accountDropdownIcon")[0].innerHTML = "&#9662;";
        }
    }
}

function addEventListenerToChefSelect() {
    var hiddenRow = document.getElementById("hiddenRow");
    var chefDropdown = document.getElementById("Recipe_ChefId");

    hiddenRow.style.display = (chefDropdown.value == 1) ? '' : 'none';

    chefDropdown.addEventListener("change", function (event) {
        hiddenRow.style.display = (event.target.value == 1) ? '' : 'none';
    });
}

function addEventListenerToRecipeSelect() {
    var recipeDropdown = document.getElementById("RecipeId");
    var viewRecipe = document.getElementById("viewRecipe");
    var reviewInputDiv = document.getElementById("reviewInputDiv");

    reviewInputDiv.style.display = (recipeDropdown.value > 0) ? '' : 'none';

    recipeDropdown.addEventListener("change", function (event) {
        viewRecipe.style.display = (event.target.value > 0) ? 'inline' : 'none';
        reviewInputDiv.style.display = (event.target.value > 0) ? '' : 'none';
        viewRecipe.href = "/Recipe/ViewRecipe/" + event.target.value;
    });
}

function addItem(text, listId, onload) {
    if (text.replace(/\s/g, "").length > 0) {
        var list = document.getElementById(listId);
        var hiddenInput = list.nextElementSibling;
        var item = document.createElement("li");
        var removeButton = document.createElement("img");
        var span = document.createElement("span");

        text = text.trim();

        removeButton.setAttribute("onClick", "removeItemFromList(this)");
        removeButton.setAttribute("src", "/images/remove.png");
        removeButton.setAttribute("title", "Remove");

        span.setAttribute("ondblclick", "editItem(this)");
        span.setAttribute("title", "Double-click to edit");
        span.append(document.createTextNode(text));

        item.append(span);
        item.append(removeButton);

        list.append(item);

        if (!onload)
            hiddenInput.value += text + ";";
    }
}

function addItemToList(listId, inputId) {
    var input = document.getElementById(inputId);

    if (input.value.length == 0)
        return;

    if (input.value.indexOf(";") != -1) {
        var texts = input.value.split(';');
        for (var i = 0; i < texts.length; i++)
            addItem(texts[i], listId, false);
    } else {
        addItem(input.value, listId, false);
    }

    input.value = "";
    input.nextElementSibling.disabled = true;
}

function carousel() {
    slideIndex += carouselPaused ? 0 : 1;
    showDivs(slideIndex);
    setTimeout(carousel, 8000);
}

function clickAccountDropdownIcon() {
    document.getElementsByClassName('accountDropdownIcon')[0].click();
}

function confirmDelete(RecipeId) {
    if (confirm("Are you sure you want to delete this recipe?")) {
        window.location.href = "/Recipe/DeleteRecipe/" + RecipeId;
    }
}

function confirmDeleteChef(ChefId) {
    if (confirm("Are you sure you want to delete this chef?")) {
        window.location.href = "/Admin/DeleteChef/" + ChefId;
    }
}

function confirmDeleteReview(RecipeReviewId, RecipeId) {
    if (confirm("Are you sure you want to delete this review?")) {
        window.location.href = "/Recipe/DeleteReview/" + RecipeReviewId + "?recipeId=" + RecipeId;
    }
}

function confirmSignOut() {
    if (confirm("Are you sure you want to sign out of Centennial Recipes?")) {
        window.location.href = "/Account/Logout";
    }
}

function editItem(element) {
    var ingredient = window.prompt("Editing \"" + element.innerHTML + "\" ingredient:", element.innerHTML);
    if (ingredient != null && ingredient.replace(/\s/g, "").length > 0) {
        if (ingredient.indexOf(';') == -1) {
            element.innerHTML = ingredient.trim();

            var list = element.parentNode.parentNode;
            var listItems = list.children;
            var hiddenInput = list.nextElementSibling;

            hiddenInput.value = "";
            for (var i = 0; i < listItems.length; i++)
                hiddenInput.value += listItems[i].childNodes[0].textContent + ";";
        } else {
            window.alert("Please do not include semi-colons.");
            editItem(element);
        }
    }
}

function initializeReviewRecipeButton() {
    var textArea = document.getElementById("Content");
    var submitButton = document.getElementById("submitReview");
    submitButton.disabled = textArea.value.replace(/\s/g, "").length == 0;
}

function onChefSelectionChanged() {
    var chefDropdown = document.getElementById("Recipe_ChefId");
    var hiddenRow = document.getElementById("hiddenRow");
    if (chefDropdown.value === 1) {
        hiddenRow.style.display = '';
    } else {
        hiddenRow.style.display = 'none';
    }
}

function onKeyEventInput(input, listId) {
    if (input.value.indexOf(';') != -1) {
        addItemToList(listId, input.id);
    }
    input.nextElementSibling.disabled = input.value.replace(/\s/g, "").length == 0;
}

function onKeyEventInputButton(input) {
    input.nextElementSibling.nextElementSibling.disabled = input.value.replace(/\s/g, "").length == 0;
}

function onLoadPopulateControls() {
    var list = document.getElementById("ingredientsList");
    var ingredientsInput = document.getElementById("Recipe_Ingredients");

    if (ingredientsInput.value.length > 0) {
        var texts = ingredientsInput.value.split(';');
        for (var i = 0; i < texts.length; i++)
            addItem(texts[i], list.id, true);
    }

    var preparationTimeInput = document.getElementById("Recipe_PreparationTime");

    if (preparationTimeInput.value.length > 0) {
        var unitDropdown = preparationTimeInput.previousElementSibling;
        var numericInput = unitDropdown.previousElementSibling;

        // get value of PreparationTime input
        var prepTimeInput = preparationTimeInput.value.split(' ');

        // set time unit
        if (prepTimeInput[1].includes("second")) {
            unitDropdown.value = 1;
        } else if (prepTimeInput[1].includes("minute")) {
            unitDropdown.value = 2;
        } else if (prepTimeInput[1].includes("hour")) {
            unitDropdown.value = 3;
        } else if (prepTimeInput[1].includes("day")) {
            unitDropdown.value = 4;
        }

        // set time magnitude
        numericInput.value = prepTimeInput[0];
    }
}

function plusDivs(offset) {
    showDivs(slideIndex += offset);
}

function removeItemFromList(element) {
    var elementItem = element.parentNode;
    var list = elementItem.parentNode;
    var listItems = list.children;
    var hiddenInput = list.nextElementSibling;

    list.removeChild(elementItem);

    hiddenInput.value = "";
    for (var i = 0; i < listItems.length; i++)
        hiddenInput.value += listItems[i].childNodes[0].textContent + ";";
}

function removeNonDigits(element) {
    element.value = element.value.replace(/\D/g, "");
}

function removeSemiColons(element) {
    element.value = element.value.replace(/;/g, "");
}

function revealPassword() {
    var passwordInput = document.getElementById("Password");
    var confirmPasswordInput = document.getElementById("ConfirmPassword");
    if (passwordInput.type === "password") {
        passwordInput.type = "text";
        if (confirmPasswordInput !== null)
            confirmPasswordInput.type = "text";
    } else {
        passwordInput.type = "password";
        if (confirmPasswordInput !== null)
            confirmPasswordInput.type = "password";
    }
}

function setCarouselPaused(paused) {
    var pause = document.getElementById("pause");
    var play = document.getElementById("play");
    carouselPaused = paused;

    if (paused) {
        pause.style.display = "none";
        play.style.display = "inline";
    } else {
        pause.style.display = "inline";
        play.style.display = "none";
    }
}

function showAccountDropdown() {
    var accountDropdown = document.getElementById("accountDropdown");
    var accountDropdownIcon = document.getElementsByClassName("accountDropdownIcon")[0];
    var display, icon;
    if (accountDropdown.style.display == 'none') {
        display = 'flex';
        icon = "&#9652;";
    } else {
        display = 'none'
        icon = "&#9662;";
    }
    accountDropdown.style.display = display;
    accountDropdownIcon.innerHTML = icon;
}

function showDivs(index) {
    var idx;
    var divs = document.getElementsByClassName("home-menu-contents");
    var divsContainer = divs[0].parentElement;
    if (index > divs.length) { slideIndex = 1; }
    if (index < 1) { slideIndex = divs.length }
    for (idx = 0; idx < divs.length; idx++) {
        divs[idx].style.display = "none";
    }
    divs[slideIndex - 1].style.display = "flex";
    divsContainer.style.backgroundImage = "url(" + backgroundImages[slideIndex - 1] + ")";
}

function tapToDismiss(element) {
    element.parentElement.style.display = "none";
}

function updateHiddenInput(list) {
    var listItems = list.children;
    var hiddenInput = list.nextElementSibling;

    hiddenInput.value = "";
    for (var i = 0; i < listItems.length; i++)
        hiddenInput.value += listItems[i].childNodes[1].innerHTML + ";";
}

function updateTimeInputElement() {
    var input = document.getElementById("Recipe_PreparationTime");
    var unitDropdown = input.previousElementSibling;
    var numericInput = unitDropdown.previousElementSibling;
    var unit;

    if ((unitDropdown.value != "") && (numericInput.value != "")) {
        switch (unitDropdown.value) {
            case "1":
                unit = "second";
                break;
            case "2":
                unit = "minute";
                break;
            case "3":
                unit = "hour";
                break;
            case "4":
                unit = "day";
                break;
        }
        if (numericInput.value > 1)
            unit = unit + 's';
        input.value = numericInput.value + " " + unit;
    } else {
        input.value = "";
    }
}