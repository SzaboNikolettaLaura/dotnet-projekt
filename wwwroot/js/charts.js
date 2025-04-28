window.createSubjectAveragesChart = (subjects, averages, colors) => {
    const ctx = document.getElementById('subjectAveragesChart').getContext('2d');
    new Chart(ctx, {
        type: 'bar',
        data: {
            labels: subjects,
            datasets: [{
                label: 'Átlag',
                data: averages,
                backgroundColor: colors,
                borderColor: colors,
                borderWidth: 1
            }]
        },
        options: {
            responsive: true,
            scales: {
                y: {
                    beginAtZero: true,
                    max: 10
                }
            }
        }
    });
};

window.createTop10Chart = (top10Average, colors) => {
    const ctx = document.getElementById('top10Chart').getContext('2d');
    new Chart(ctx, {
        type: 'doughnut',
        data: {
            labels: ['Top 10% Átlag', 'Egyéb'],
            datasets: [{
                data: [top10Average, 10 - top10Average],
                backgroundColor: colors,
                borderWidth: 1
            }]
        },
        options: {
            responsive: true
        }
    });
}; 