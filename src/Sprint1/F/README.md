<div class="header">
    <h1 class="title">F. Палиндром</h1>
    <table>
        <tbody><tr class="time-limit">
        <td class="property-title">Ограничение времени</td>
        <td>1&nbsp;секунда</td>
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
        <p>Помогите Васе понять, будет ли фраза палиндромом‎. Учитываются только буквы и цифры, заглавные и строчные буквы считаются
        одинаковыми.
        </p></span><p>Решение должно работать за <span class="tex-math-text">O(N)</span>, где <span class="tex-math-text">N</span> — длина строки на входе.
    </p>
</div>
<h2>Формат ввода</h2>
<div class="input-specification"><span style="">
        <p>В единственной строке записана фраза или слово. Буквы могут быть только латинские. Длина текста не превосходит <span class="tex-math-text">20000</span> символов.
        </p></span><p>Фраза может состоять из строчных и прописных латинских букв, цифр, знаков препинания.</p>
</div>
<h2>Формат вывода</h2>
<div class="output-specification"><span style="">
        <p>Выведите «True», если фраза является палиндромом, и «False», если не является.</p></span></div>
<h3>Пример 1</h3>
<table class="sample-tests">
    <thead>
        <tr>
        <th>Ввод<div class="problem__copy-sample"></div></th>
        <th>Вывод<div class="problem__copy-sample"></div></th>
        </tr>
    </thead>
    <tbody>
        <tr>
        <td><pre>A man, a plan, a canal: Panama
</pre></td>
        <td><pre>True</pre></td>
        </tr>
    </tbody>
</table>
<h3>Пример 2</h3>
<table class="sample-tests">
    <thead>
        <tr>
        <th>Ввод<div class="problem__copy-sample"></div></th>
        <th>Вывод<div class="problem__copy-sample"></div></th>
        </tr>
    </thead>
    <tbody>
        <tr>
        <td><pre>zo
</pre></td>
        <td><pre>False</pre></td>
        </tr>
    </tbody>
</table>
