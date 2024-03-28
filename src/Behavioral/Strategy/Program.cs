using Strategy;

var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

var editor = new TextEditor(new UpperCaseStrategy());
editor.ProcessText(text);

editor.SetStrategy(new LowerCaseStrategy());
editor.ProcessText(text);

editor.SetStrategy(new ReverseStrategy());
editor.ProcessText(text);