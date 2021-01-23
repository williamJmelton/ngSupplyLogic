import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
// import { WordList } from './wordList';

// import * as ace from 'ace-builds';
// import 'ace-builds/src-noconflict/mode-javascript';
// import 'ace-builds/src-noconflict/theme-dracula';
// import 'ace-builds/src-noconflict/ext-language_tools';

// const THEME = 'ace/theme/dracula';
// const LANGJS = 'ace/mode/javascript';
// const LANGABC = 'ace/mode/abc';
// const LANGDARI = 'ace/mode/dari';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home-component.scss']
})
export class HomeComponent implements OnInit {
  // staticWordCompleter = {
  //   getCompletions: function (editor, session, pos, prefix, callback) {
  //     if (prefix.length === 0) {
  //       callback(null, []);
  //       return
  //     }
  //     var wordList = WordList;
  //     callback(null, [...wordList.map(function (word) {
  //       return {
  //         caption: word,
  //         value: word,
  //         meta: "static"
  //       };
  //     }),
  //       // DIS SHYT DON'T WORK BOI
  //       // ...session.$mode.$highlightRules.$keywordList.map(function (word) {
  //       //   return {
  //       //     caption: word,
  //       //     value: word,
  //       //     meta: 'keyword',
  //       //   };
  //       // })
  //     ]);

  //   }
  // }

  // @ViewChild('codeEditor', { read: false, static: false }) codeEditorElmRef: ElementRef;
  // private codeEditor: ace.Ace.Editor;


  ngOnInit() {
    // ace.require(`ace/ext/language_tools`);
    // const element = this.codeEditorElmRef.nativeElement;
    // const editorOptions = this.getEditorOptions();

    // this.codeEditor = ace.edit(element, editorOptions);
    // this.codeEditor.setTheme(THEME);
    // this.codeEditor.completers = [this.staticWordCompleter];
    // this.codeEditor.getSession().setMode(LANGJS);
    // this.codeEditor.setShowFoldWidgets(true); // for the scope fold feature
  }

  // private getEditorOptions(): Partial<ace.Ace.EditorOptions> & { enableBasicAutocompletion?: boolean; } {
  //   const basicEditorOptions: Partial<ace.Ace.EditorOptions> = {
  //     highlightActiveLine: false,
  //     minLines: 14,
  //     maxLines: Infinity,
  //     fontSize: 20,
  //     showGutter: false,
  //     highlightSelectedWord: false,
  //   };

  //   const extraEditorOptions = {
  //     enableBasicAutocompletion: true,
  //     enableLiveAutocompletion: true,
  //   };
  //   const margedOptions = { ...basicEditorOptions, ...extraEditorOptions }
  //   return margedOptions;
  // }
}
