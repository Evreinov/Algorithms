<fieldset class="problem__item"><div class="problem__statement text" data-bem="{&quot;problem__statement&quot;:{}}">
<div class="problem-statement">
   <div class="header">
      <h1 class="title">I. Ограниченная очередь</h1>
      <table>
         <tbody><tr class="time-limit">
            <td class="property-title">Ограничение времени</td>
            <td>0.3&nbsp;секунды</td>
         </tr>
         <tr class="memory-limit">
            <td class="property-title">Ограничение памяти</td>
            <td>64Mb</td>
         </tr>
         <tr class="input-file">
            <td class="property-title">Ввод</td>
            <td colspan="1">стандартный ввод или input.txt</td>
         </tr>
         <tr class="output-file">
            <td class="property-title">Вывод</td>
            <td colspan="1">стандартный вывод или output.txt</td>
         </tr>
      </tbody></table>
   </div>
   <h2></h2>
   <div class="legend"><span style="">
         <p>Астрологи объявили день очередей ограниченного размера. Тимофею нужно написать класс&nbsp;<span class="tex-monospace">MyQueueSized</span>, который принимает параметр&nbsp;<span class="tex-monospace">max_size</span>, означающий максимально допустимое количество элементов в очереди. 
         </p></span><p>Помогите ему —– реализуйте программу, которая будет эмулировать работу такой очереди. Функции, которые надо поддержать, описаны в формате
         ввода.
      </p>
   </div>
   <h2>Формат ввода</h2>
   <div class="input-specification"><span style="">
         <p>В первой строке записано одно число — количество команд, оно не превосходит 5000.<br>Во второй строке задан максимально допустимый размер очереди, он не превосходит 5000.<br>Далее идут команды по одной на строке. Команды могут быть следующих видов: 
            </p><ul>
               <li><span class="tex-monospace">push(x)</span> — добавить число <span class="tex-math-text">x</span> в очередь;
                  <p></p>
               </li>
               <li><span class="tex-monospace">pop()</span> — удалить число из очереди и вывести на печать;
                  <p></p>
               </li>
               <li><span class="tex-monospace">peek()</span> — напечатать первое число в очереди;
                  <p></p>
               </li>
               <li><span class="tex-monospace">size()</span> — вернуть размер очереди; 
               </li>
            </ul>При превышении допустимого размера очереди нужно вывести «error». При вызове операций <span class="tex-monospace">pop()</span> или <span class="tex-monospace">peek()</span> для пустой очереди нужно вывести «None».
         <p></p></span></div>
   <h2>Формат вывода</h2>
   <div class="output-specification"><span style="">
         <p>Напечатайте результаты выполнения нужных команд, по одному на строке.</p></span></div>
   <h3>Пример 1</h3>
   <table class="sample-tests">
      <thead>
         <tr>
            <th>Ввод<div class="problem__copy-sample"><button class="button button_theme_pseudo button_size_s button_only-icon_yes problem__copy-button problem__copy-button_type_input i-bem" data-bem="{&quot;button&quot;:{}}" role="button" type="button" title="Скопировать ввод"><span class="button__text">&nbsp;<img class="image button__icon button__icon_role_copy" src="//yastatic.net/lego/_/La6qi18Z8LwgnZdsAr1qy1GwCwo.gif" alt="Скопировать ввод"></span></button></div></th>
            <th>Вывод<div class="problem__copy-sample"><button class="button button_theme_pseudo button_size_s button_only-icon_yes problem__copy-button problem__copy-button_type_output i-bem" data-bem="{&quot;button&quot;:{}}" role="button" type="button" title="Скопировать вывод"><span class="button__text">&nbsp;<img class="image button__icon button__icon_role_copy" src="//yastatic.net/lego/_/La6qi18Z8LwgnZdsAr1qy1GwCwo.gif" alt="Скопировать вывод"></span></button></div></th>
         </tr>
      </thead>
      <tbody>
         <tr>
            <td><pre>8
2
peek
push 5
push 2
peek
size
size
push 1
size
</pre></td>
            <td><pre>None
5
2
2
error
2
</pre></td>
         </tr>
      </tbody>
   </table>
   <h3>Пример 2</h3>
   <table class="sample-tests">
      <thead>
         <tr>
            <th>Ввод<div class="problem__copy-sample"><button class="button button_theme_pseudo button_size_s button_only-icon_yes problem__copy-button problem__copy-button_type_input i-bem" data-bem="{&quot;button&quot;:{}}" role="button" type="button" title="Скопировать ввод"><span class="button__text">&nbsp;<img class="image button__icon button__icon_role_copy" src="//yastatic.net/lego/_/La6qi18Z8LwgnZdsAr1qy1GwCwo.gif" alt="Скопировать ввод"></span></button></div></th>
            <th>Вывод<div class="problem__copy-sample"><button class="button button_theme_pseudo button_size_s button_only-icon_yes problem__copy-button problem__copy-button_type_output i-bem" data-bem="{&quot;button&quot;:{}}" role="button" type="button" title="Скопировать вывод"><span class="button__text">&nbsp;<img class="image button__icon button__icon_role_copy" src="//yastatic.net/lego/_/La6qi18Z8LwgnZdsAr1qy1GwCwo.gif" alt="Скопировать вывод"></span></button></div></th>
         </tr>
      </thead>
      <tbody>
         <tr>
            <td><pre>10
1
push 1
size
push 3
size
push 1
pop
push 1
pop
push 3
push 3
</pre></td>
            <td><pre>1
error
1
error
1
1
error
</pre></td>
         </tr>
      </tbody>
   </table>
</div></div><a name="2989/2020_04_22/AEx9tN3sns"></a><div class="problem__messages"><div class="problem__available-message"></div></div><div class="problem__solution"><div class="solution solution_type_compiler-list i-bem solution_js_inited" data-bem="{&quot;solution&quot;:{&quot;id&quot;:&quot;2989/2020_04_22/AEx9tN3sns@compilerId&quot;,&quot;problemId&quot;:&quot;2989/2020_04_22/AEx9tN3sns&quot;,&quot;compilerId&quot;:&quot;dotnet6_asp&quot;,&quot;maxFileSize&quot;:262144,&quot;submissionTemplateUrl&quot;:&quot;/ajax/contest/22779/problem/submission/template&quot;,&quot;lastSubmissionUrl&quot;:&quot;/ajax/contest/22779/last-submission&quot;,&quot;validation&quot;:{}}}"><label class="solution__label" for="2989/2020_04_22/AEx9tN3sns@compilerId">Язык</label><span class="select select_size_s select_theme_normal select_role_compiler-list select_layout_fixed-l i-bem select_js_inited" data-bem="{&quot;select&quot;:{&quot;rows&quot;:8,&quot;live&quot;:true,&quot;selected&quot;:&quot;dotnet6_asp&quot;}}"><button class="button button_theme_normal button_arrow_down button_size_s select__button i-bem button_js_inited" data-bem="{&quot;button&quot;:{}}" role="listbox" type="button" aria-haspopup="true" aria-expanded="false"><span class="button__text">C# (MS .NET 6.0 + ASP)</span></button><select class="select__control" name="2989/2020_04_22/AEx9tN3sns@compilerId" id="uniq17100994315251523" tabindex="-1" aria-hidden="true" autocomplete="off" value="dotnet6_asp"><option class="select__option" value="dotnet5_asp">C# (MS .NET 5.0 + ASP)</option><option class="select__option" value="dotnet6_asp" selected="selected">C# (MS .NET 6.0 + ASP)</option><option class="select__option" value="gcc7_3">GNU c++17 7.3</option><option class="select__option" value="gcc_cpp20">GNU GCC 13.1 C++20</option><option class="select__option" value="gcc7_c11">GNU GCC 7.3 C11</option><option class="select__option" value="golang_docker">Golang 1.21.0</option><option class="select__option" value="kotlin_1_8_0">Kotlin 1.8.0 (JRE 11)</option><option class="select__option" value="make">Make</option><option class="select__option" value="nodejs_new">Node.js 14.15.5</option><option class="select__option" value="openjdk11_x64">OpenJDK Java 11</option><option class="select__option" value="python3_docker">Python 3.12.1</option><option class="select__option" value="swift-5_1">Swift 5.9.2</option></select></span></div><div class="solution solution_type_group solution_selected_text i-bem solution_js_inited" data-bem="{&quot;solution&quot;:{&quot;id&quot;:&quot;2989/2020_04_22/AEx9tN3sns@solution&quot;,&quot;problemId&quot;:&quot;2989/2020_04_22/AEx9tN3sns&quot;,&quot;compilerId&quot;:&quot;dotnet6_asp&quot;,&quot;maxFileSize&quot;:262144,&quot;submissionTemplateUrl&quot;:&quot;/ajax/contest/22779/problem/submission/template&quot;,&quot;lastSubmissionUrl&quot;:&quot;/ajax/contest/22779/last-submission&quot;}}"><div class="solution__field solution__field_role_switcher"><span class="radio-button radio-button_size_s radio-button_theme_normal i-bem radio-button_js_inited" data-bem="{&quot;radio-button&quot;:{&quot;live&quot;:false}}"><label class="radio-button__radio radio-button__radio_checked_yes radio-button__radio_pressed_yes radio-button__radio_side_left" for="uniq17100994315251524"><input class="radio-button__control" value="text" checked="checked" id="uniq17100994315251524" type="radio" name="2989/2020_04_22/AEx9tN3sns@solution"><span class="radio-button__text">Набрать здесь</span></label><label class="radio-button__radio radio-button__radio_side_right radio-button__radio_next-for-pressed_yes" for="uniq17100994315251525"><input class="radio-button__control" value="file" id="uniq17100994315251525" type="radio" name="2989/2020_04_22/AEx9tN3sns@solution"><span class="radio-button__text">Отправить файл</span></label></span></div><div class="solution__field solution__field_role_panes"><div class="solution__pane solution__pane_name_text solution__pane_selected_yes"><span class="input input_type_textarea input_size_s input_role_code-type-text input_theme_normal i-bem input_js_inited" data-bem="{&quot;input&quot;:{&quot;live&quot;:false}}"><span class="input__box"><textarea class="input__control" id="uniq17100994315251526" name="2989/2020_04_22/AEx9tN3sns@text" aria-labelledby="labeluniq17100994315251526 hintuniq17100994315251526" rows="8" cols="10" style="display: none;"></textarea><div class="CodeMirror cm-s-neat"><div style="overflow: hidden; position: relative; width: 3px; height: 0px; top: 4px; left: 33px;"><textarea style="position: absolute; padding: 0px; width: 1px; height: 1em; outline: none;" wrap="off" autocorrect="off" autocapitalize="none" spellcheck="false" tabindex="0"></textarea></div><div class="CodeMirror-hscrollbar" style="left: 29px; min-height: 18px;"><div style="height: 100%; min-height: 1px; width: 0px;"></div></div><div class="CodeMirror-vscrollbar" style="min-width: 18px;"><div style="min-width: 1px; height: 0px;"></div></div><div class="CodeMirror-scrollbar-filler"></div><div class="CodeMirror-gutter-filler"></div><div class="CodeMirror-scroll" tabindex="-1" draggable="true"><div class="CodeMirror-sizer" style="margin-left: 29px; min-width: 7px; min-height: 21px;"><div style="position: relative; top: 0px;"><div class="CodeMirror-lines"><div style="position: relative; outline: none;"><div class="CodeMirror-measure"><div style="width: 50px; height: 50px; overflow-x: scroll;"></div></div><div class="CodeMirror-measure"></div><div style="position: relative; z-index: 1;"></div><div class="CodeMirror-cursors"><div class="CodeMirror-cursor" style="left: 4px; top: 0px; height: 13px;">&nbsp;</div></div><div class="CodeMirror-code"><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" style="position: absolute; left: -29px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 0px; width: 20px;">1</div></div><pre class=""><span><span>​</span></span></pre></div></div></div></div></div></div><div style="position: absolute; height: 30px; width: 1px; top: 21px;"></div><div class="CodeMirror-gutters" style="height: 200px;"><div class="CodeMirror-gutter CodeMirror-linenumbers" style="width: 28px;"></div></div></div></div><span class="input__clear" unselectable="on"></span></span></span></div><div class="solution__pane solution__pane_name_file"><span class="attach attach_theme_normal attach_size_s attach_disabled_yes attach_role_code-type-attach attach_for_contest i-bem attach_js_inited" data-bem="{&quot;attach&quot;:{&quot;live&quot;:false}}"><span class="button button_theme_normal button_size_s button_disabled_yes attach__button i-bem" data-bem="{&quot;button&quot;:{}}"><span class="button__text" id="textuniq17100994315251527" aria-hidden="true">Выбрать</span><input class="attach__control button__control" type="file" name="2989/2020_04_22/AEx9tN3sns@file" id="uniq17100994315251527" aria-labelledby="textuniq17100994315251527" disabled="disabled"></span><span class="attach__holder attach__holder_state_hidden attach__holder_file_unknown" aria-hidden="true"><img class="image attach__icon-file" src="//yastatic.net/lego/_/La6qi18Z8LwgnZdsAr1qy1GwCwo.gif" alt=""><span class="attach__text">Файл не выбран</span><img class="image attach__reset attach__reset_visibility_visible" src="//yastatic.net/lego/_/La6qi18Z8LwgnZdsAr1qy1GwCwo.gif" alt=""></span></span></div></div></div></div></fieldset><div class="problem__send"><input type="hidden" name="sk" value="u93378374163d0adc2c2edfadd4e97ea7"><input type="hidden" name="retpath" value="https://contest.yandex.ru/contest/22779/problems/I/#2989/2020_04_22/AEx9tN3sns"><button class="button button_theme_action button_size_s button_role_submit i-bem" data-bem="{&quot;button&quot;:{}}" role="button" type="submit"><span class="button__text">Отправить</span></button></div><div class="problem__attempts"><div class="msg msg_type_info"><img class="image msg__icon" src="//yastatic.net/lego/_/La6qi18Z8LwgnZdsAr1qy1GwCwo.gif" alt=""><img class="image msg__icon" src="//yastatic.net/lego/_/La6qi18Z8LwgnZdsAr1qy1GwCwo.gif" alt="">осталось 100 попыток</div></div><div class="problem__problems-nav"><span class="problem__problems-nav-left"><a class="button button_theme_normal button_size_s i-bem" data-bem="{&quot;button&quot;:{}}" role="button" href="/contest/22779/problems/H/"><span class="button__text">Предыдущая</span></a></span><span class="problem__problems-nav-right"><a class="button button_theme_normal button_size_s i-bem" data-bem="{&quot;button&quot;:{}}" role="button" href="/contest/22779/problems/J/"><span class="button__text">Следующая</span></a></span></div>