fetch('/ui/data/resonance-legend.json')
  .then(response => response.json())
  .then(data => {
    const grid = document.querySelector('.grid');
    data.elements.forEach(el => {
      const tile = document.createElement('div');
      tile.className = 'element';
      tile.style.backgroundColor = el.color;
      tile.setAttribute('data-symbol', el.symbol);
      tile.setAttribute('data-frequency', el.frequency);

      tile.innerHTML = `
        <span class="symbol">${el.symbol}</span>
        <span class="freq">${el.frequency} Hz</span>
        <span class="role">${el.role}</span>
        <div class="tooltip">${el.notes}. Color: ${el.color}</div>
      `;

      grid.appendChild(tile);
    });
  });
