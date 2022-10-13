$(document).ready(function () { 
    
    function random(min, max) {
        return Math.floor(Math.random() * (max - min)) + min
    }

    const names = ["Şahbatur", "Gülbatur", "Canbatur", "Şahinbey", "Abakay Kızı", "Abaküs"]

    $("#btnCount").click(function () {
      
        const count = $("#count").val();

        if (isNaN(count)) {
            alert("Lütfen sayısal değer giriniz");
            $("#count").val("");
            return;
        }

        if (count > 6) {
            alert("Makimum at sayısı bir yarışta 6 adettir");
            return;
        }

        let template = [];

        for (let i = 1; i <= count; i++) {
            template.push(`<div class="row"><div class="col">
                             <img src="./img/h${i}.gif" alt=""></div></div>`);
        }
        document.getElementById("container").innerHTML = template.join("<br>");
        $("#count").val("");

        $(".h4").removeClass("d-none");
        $(".h4").text("Yarış Birazdan Başlamak Üzere");
    })



    $("#btnStart").click(function () {
        var horses = document.getElementsByTagName("img");
        if (horses.length == 0) {
            alert("Lütfen At Sayısı Giriniz");
            return;
        }
        let lblFinish = $("#finish-line").position().left;

        var timer = setInterval(() => { 
            $.each(horses, (key, value) => {
                const itemWidth = $(value).position().left + $(value).width();

                let _counter = 0;
                let _winner = -1;

                for (let i = 0; i < horses.length; i++) {
                    if ($(horses[i]).position().left > _counter) {
                        _counter = $(horses[i]).position().left;
                        _winner = i;
                    }
                }

                $(".h4").text(`yarışı ${_winner + 1} kulvardaki ${names[_winner]}  önde götürüyor`);

                if (itemWidth > lblFinish) {
                    clearInterval(timer);
                    alert("Yarışı " + (key + 1) + " numaralı at kazandı");
                    $("img").addClass("d-none");
                    $(".h4").addClass("d-none");
                    return;
                }

                let position = $(value).position().left;
                let m = random(5, 30) + position;
                $(value).css("left", m)

            })
        }, 70);
    })
})